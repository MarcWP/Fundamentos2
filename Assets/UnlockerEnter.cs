using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockerEnter : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "jugador")
        {
            GameEvent.current.pickUp();
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }
}
