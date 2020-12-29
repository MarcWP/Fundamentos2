using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    private float characterVelocity = 2f;
    private Vector2 movDir;
    private Vector2 movementPerSecond;
    private SpriteRenderer spriteRend;
    private float randomDir;
    private float comp;


    void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
        comp = randomDir;

    }

    void calcuateNewMovementVector()
    {
        //Movimiento random a los lados*velocidad
        randomDir = Random.Range(-1.0f, 1.0f);
        movDir = new Vector2(randomDir, 0).normalized;
        movementPerSecond = movDir * characterVelocity;
        if (randomDir > 0)
        {
            spriteRend.flipX = true;
        }
        else
        {
            spriteRend.flipX = false;
        }
        comp = randomDir;
    }

    void Update()
    {
        //Cada X tiempo cambiamos de dirección
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }

        //Movemos al enemigo
        transform.position = new Vector2(transform.position.x + (movementPerSecond.x * Time.deltaTime),
        transform.position.y + (movementPerSecond.y * Time.deltaTime));

    }
}
