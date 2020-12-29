using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeverAction : MonoBehaviour
{
    public GameObject caja;
    public GameObject jugador;

    private void Start()
    {
        GameEvent.current.onLeverEvent += spawnBox;
    }

    private void spawnBox()
    {
        if((Vector3.Distance(jugador.transform.position, transform.position) <= 1f))
        caja.SetActive(true);
    }

}
