using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCBGLoop : MonoBehaviour
{
    public Vector3 ini;
    public GameObject player;
    public GameObject fondo;
    // Start is called before the first frame update
    void Start()
    {
        //nos subscribimos al evento de movimiento   
        ini = gameObject.transform.position;
    }

    // Update is called once per frame
    /*void Update()
    {
        if (true)
        {
            transform.position.x + anchoFondo < cameraTransform.position.x
        }
    }*/

    private void Update()
    {
        if(player.transform.position.x> (fondo.transform.position.x+fondo.GetComponent<SpriteRenderer>().bounds.size.x/2))
            transform.position = new Vector3(transform.position.x+ fondo.GetComponent<SpriteRenderer>().bounds.size.x, 0, -10);
        else if (player.transform.position.x < (fondo.transform.position.x - fondo.GetComponent<SpriteRenderer>().bounds.size.x / 2))
            transform.position = new Vector3(transform.position.x - fondo.GetComponent<SpriteRenderer>().bounds.size.x, 0, -10);

    }


}
