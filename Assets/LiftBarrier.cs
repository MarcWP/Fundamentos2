using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftBarrier : MonoBehaviour
{

    //Nos suscribimos al evento de recogida
    private void Start()
    {
        GameEvent.current.onPickUp += liftBarrier;
    }

    //Si se recoge la gema, se levanta la barrera
    private void liftBarrier()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 8.7f, transform.position.z);
    }

}
