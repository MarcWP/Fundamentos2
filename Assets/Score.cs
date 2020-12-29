using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scorePoints = 0;
    private Text score;

    private void Start()
    {
        score = GetComponent<Text>();
        GameEvent.current.onPickUp += addPoints;
    }

    private void addPoints()
    {
        scorePoints = scorePoints + 1000;
        score.text = "Puntos:" + scorePoints;
    }
}
