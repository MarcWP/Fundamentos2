using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollOnLimit : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        /*if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > 0)
        { 
            GameEvent.current.camScroll();
        }*/
        if (Input.anyKey)
        {
            GameEvent.current.camScroll();
        }
    }
}
