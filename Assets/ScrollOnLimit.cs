using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollOnLimit : MonoBehaviour
{
    public Transform player;

    //Al pulsar las teclas A o D de movimiento horizontal, aplicamos el efecto scroll
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            GameEvent.current.camScroll();
        }
    }
}
