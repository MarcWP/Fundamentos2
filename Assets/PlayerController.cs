using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public bool grounded;
    private Rigidbody2D rigidbody2d;
    private SpriteRenderer spriteRend;
    private Animator animator;
    public GameObject enemigo;

    private void Start()
    {
        spriteRend = gameObject.GetComponent<SpriteRenderer>();
        grounded = true;
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Controles del jugador

        //Acción explotar
        if (Input.GetKey(KeyCode.X))
        {
            enemigo.GetComponent<Animator>().SetBool("explode", true);
        }
        //Moverse a la izquierda y flip a sprites
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            spriteRend.flipX=true;
            animator.SetBool("correr", true);
        }

        //Moverse a la derecha y flip a sprites
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            spriteRend.flipX = false;
            animator.SetBool("correr", true);
        }

        //Parar
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("correr", false);
        }
        
        //La propiedad grounded se gestiona en los "pies" del jugador
        if (grounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rigidbody2d.velocity = Vector2.up * jumpSpeed;
                grounded = false;
            }
        }

        //Acción usar
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameEvent.current.leverEvent();
        }

    }


}