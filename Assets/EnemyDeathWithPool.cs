using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathWithPool : MonoBehaviour
{

    public float forceMultiplier;

    public GameObject Manager;

    private float Timer;

    public float tt;

    //Timer para manejar el daño
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si  el jugador golpea al enemigo por encima lo destruimos
        if (collision.tag == "jugador")
        {
            if ((collision.transform.position.y - (collision.GetComponent<BoxCollider2D>().size.y * collision.transform.localScale.y) / 2) > (transform.position.y + (gameObject.GetComponent<BoxCollider2D>().size.y * gameObject.transform.localScale.y) / 2))
            {
                //En este caso, devolvemos el enemigo a la pool, podemos usar métodos públicos o eventos
                //GameObject.FindGameObjectWithTag("Manager").GetComponent<Pooler>().returnObject(gameObject);
                GameEvent.current.tkPool(gameObject);
                //Podemos gestionar los puntos reutilizando el evento pickUp
                GameEvent.current.pickUp();
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
                    Timer = tt;

                }

            }
        }
    }
}
