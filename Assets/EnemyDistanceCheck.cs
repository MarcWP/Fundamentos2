using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistanceCheck : MonoBehaviour
{
    public float forceMultiplier;

    float Timer;

    //Timer para manejar el daño
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
    }

    //Si  el jugador golpea al enemigo por encima lo destruimos
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "jugador")
        {
            if ((collision.transform.position.y - (collision.GetComponent<BoxCollider2D>().size.y * collision.transform.localScale.y)/2) > (transform.position.y + (gameObject.GetComponent<BoxCollider2D>().size.y * gameObject.transform.localScale.y)/2) )
            {
                gameObject.GetComponent<Animator>().SetBool("explode", true);
            }
            //Si no golpeamos al enemigo por encima recibimos daño
            else
            {
                //Para evitar que el jugador tome daño constantemente usamos un contador y aplicamos knockback
                if (Timer <= 0)
                {
                    GameEvent.current.takeHit();
                    Vector2 knockbackVelocity = new Vector2((transform.position.x - collision.transform.position.x) * forceMultiplier, (transform.position.y - collision.transform.position.y) * forceMultiplier);
                    collision.GetComponent<Rigidbody2D>().velocity = -knockbackVelocity;
                    Timer = 0.5f;
                    //collision.GetComponent<Rigidbody2D>().AddForce(-knockbackVelocity);
                    
                }

            }
        }
    }
}
