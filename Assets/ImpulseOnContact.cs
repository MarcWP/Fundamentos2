using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulseOnContact : MonoBehaviour
{

    //Se genera una vibración de cinemachine en contacto con el jugador

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="jugador")
        {
            gameObject.GetComponent<CinemachineImpulseSource>().GenerateImpulse(1f);
        }
    }

    

}
