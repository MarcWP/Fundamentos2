using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBorderLimit : MonoBehaviour
{
    //public float speed;
    //public GameObject fondo;
    private float length;
    private float startpos;
    public GameObject cam;
    public float parallaxEffect;
    //Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        GameEvent.current.onCamScroll += scroll;
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void scroll()
    {
        //transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x,0,0)+new Vector3(10000, 0,0), Time.deltaTime*speed);
        //transform.position = new Vector3(transform.position.x, 0, -10)+ new Vector3(transform.localScale.x*18, 0, 0);
        //transform.position = new Vector3(transform.position.x+ fondo.GetComponent<SpriteRenderer>().bounds.size.x, 0, -10);
        float temp = (cam.transform.position.x * (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;

    }
}
