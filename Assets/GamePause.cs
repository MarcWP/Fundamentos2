using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{

    //El juego empieza pausado
    private void Start()
    {
        Time.timeScale = 0f;
        GameEvent.current.onPauseFlow += pauseControl;
    }

    //Pequeño método para demostrar que es posible pasar parámetros durante eventos.
    private void pauseControl(int select)
    {
        //dependiendo de si el parámetro es 1 o 0, pausamos o despausamos
        if (select==1)
        {
            Time.timeScale = 1;
        }
        else if (select == 0)
        {
            Time.timeScale = 0f;
        }
    }
}
