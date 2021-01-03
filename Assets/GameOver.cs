using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject finalText;
    public string escena;
    //Suscripción al evento de aparición del texto final y click del botón en la caja de texto
    private void Start()
    {
        GameEvent.current.onDeath += deathText;
        GameEvent.current.onClick += restart;
    }
    //En el caso de muerte, se activa el mensaje final y se pausa el tiempo
    private void deathText()
    {
        finalText.SetActive(true);
        GameEvent.current.pauseFlow(0);
    }

    //Suscribiendo las clases a eventos, podemos mantener los métodos privados
    private void restart()
    {
        SceneManager.LoadScene(escena);
    }
}
