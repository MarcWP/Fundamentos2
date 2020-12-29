using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxToFace : MonoBehaviour
{
    public float speed;
    private Vector3 ini;
    // Update is called once per frame
    private void Start()
    {
        ini = gameObject.transform.position;
    }

    void Update()
    {
        gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrera")
        {
            gameObject.transform.position = ini;
        }
        if (collision.gameObject.tag == "Barrera2")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());
            
        }
    }
}
