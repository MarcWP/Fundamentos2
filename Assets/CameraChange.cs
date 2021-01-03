using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject camA;
    public GameObject camB;
    public GameObject camCom;

    //Manejo de las cámaras controlado con las teclas B, N y M
    private void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            camA.SetActive(true);
            camCom.SetActive(false);
            camB.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.N))
        {
            camA.SetActive(false);
            camCom.SetActive(false);
            camB.SetActive(true);
        }
        else if (Input.GetKey(KeyCode.M))
        {
            camA.SetActive(false);
            camCom.SetActive(true);
            camB.SetActive(false);
        }
    }
}
