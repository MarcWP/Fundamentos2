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

        if (Input.GetKey(KeyCode.X))
        {
            enemigo.GetComponent<Animator>().SetBool("explode", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            spriteRend.flipX=true;
            animator.SetBool("correr", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            spriteRend.flipX = false;
            animator.SetBool("correr", true);
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("correr", false);
        }
        
        if (grounded)
        {
            if (Input.GetKey(KeyCode.W))
            {
                //GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpSpeed);
                rigidbody2d.velocity = Vector2.up * jumpSpeed;
                grounded = false;
            }
        }
        /*
        if (enemigo)
        {
            if (Vector3.Distance(enemigo.transform.position, transform.position) <= 1f)
            {
                enemigo.GetComponent<Animator>().SetBool("explode", true);
            }
        }*/
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            GameEvent.current.leverEvent();
        }

    }

    
}