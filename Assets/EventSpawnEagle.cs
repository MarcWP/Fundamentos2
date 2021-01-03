using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSpawnEagle : MonoBehaviour
{

    public GameObject eagle;
    //Suscribimo el script al evento de pickUp invocar un enemigo
    private void Start()
    {
        GameEvent.current.onPickUp += activateEagle;
    }

    //Podemos hacer esto en la clase donde se maneja la recogida de la gema
    //Para demostrar la subscripción de eventos lo haremos aquí
    private void activateEagle()
    {
        eagle.SetActive(true);
    }
}
