using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DhasPlatform : MonoBehaviour
{
    public float force;

    //Al colisionar con el jugador, lo empujamos
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="jugador")
        {
            collision.rigidbody.AddForce(Vector3.right * force);
            //Mensaje para consola
            print("Has entrado en contacto con una caja que empuja");
        }
    }
}
