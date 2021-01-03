using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ascensor : MonoBehaviour
{
    public AnimationCurve myCurve;

    void Update()
    {
        //Edición de la posición de cubo kinemático mediante curva de animación
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }

    //Si colisionamos con el objeto kinemático mandamos un mensaje
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="jugador")
        {
            print("Estás en el ascensor");
        }
    }
}
