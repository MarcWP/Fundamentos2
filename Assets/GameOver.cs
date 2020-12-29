using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject finalText;
    public string escena;
    private void Start()
    {
        GameEvent.current.onDeath += deathText;
    }

    private void deathText()
    {
        finalText.SetActive(true);
        GameEvent.current.pauseFlow(0);
    }

    public void restart()
    {
        SceneManager.LoadScene(escena);
    }
}
