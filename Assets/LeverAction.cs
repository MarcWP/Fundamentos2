using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverAction : MonoBehaviour
{
    public GameObject caja;
    public GameObject jugador;

    //Suscripción al evento de acción
    private void Start()
    {
        GameEvent.current.onLeverEvent += spawnBox;
    }

    //Al usar la tecla E cerca de la palanca, activamos una caja localizada en la zona superior del mapa
    private void spawnBox()
    {
        if((Vector3.Distance(jugador.transform.position, transform.position) <= 1f))
        caja.SetActive(true);
    }

}
