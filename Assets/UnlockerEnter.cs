using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockerEnter : MonoBehaviour
{

    //Al entrar en la zona trigger de la gema, la desactivamos y llamamos al evento correspondiente
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "jugador")
        {
            //Usamos eventos OnCollider/OnTrigger al mismo tiempo que eventos por suscripción para demostrar funcionalidad
            GameEvent.current.pickUp();
            gameObject.SetActive(false);
            //Mensaje para consola
            print("Has recogido una gema");
        }
    }
}
