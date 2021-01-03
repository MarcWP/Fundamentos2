using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scorePoints = 0;
    private Text score;

    //Nos suscribimos al evento pickUp que se utiliza como señal para agregar puntos
    private void Start()
    {
        score = GetComponent<Text>();
        GameEvent.current.onPickUp += addPoints;
    }

    //Agregamos puntos al "marcador"
    private void addPoints()
    {
        scorePoints = scorePoints + 1000;
        score.text = "Puntos:" + scorePoints;
    }
}
