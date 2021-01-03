using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scroll : MonoBehaviour
{
    public float speed;

    //Scroll de la textura localizada en el quad
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
