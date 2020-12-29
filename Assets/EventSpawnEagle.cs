using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSpawnEagle : MonoBehaviour
{

    public GameObject eagle;
    private void Start()
    {
        GameEvent.current.onPickUp += activateEagle;
    }

    private void activateEagle()
    {
        eagle.SetActive(true);
    }
}
