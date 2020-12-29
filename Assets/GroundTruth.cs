using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTruth : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            GetComponentInParent<PlayerController>().grounded = true;
        }
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            GetComponentInParent<PlayerController>().grounded = false;
        }
    }
}
