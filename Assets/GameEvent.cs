using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{
    public static GameEvent current;

    private void Awake()
    {
        current = this;
    }
    //Aqui empiezan los eventos

    //Evento lever para la palanca
    public event Action onLeverEvent;

    public void leverEvent()
    {
        if (onLeverEvent != null)
        {
            onLeverEvent();
        }
    }

    //Evento pickUp para cuando se recoge un objeto
    public event Action onPickUp;

    public void pickUp()
    {
        if (onPickUp != null)
        {
            onPickUp();
        }
    }

    //Evento TakeHit para cuando se recibe daño
    public event Action onTakeHit;

    public void takeHit()
    {
        if (onTakeHit != null)
        {
            onTakeHit();
        }
    }

    //Evento pause para el manejo del flow del juego
    public event Action<int> onPauseFlow;

    public void pauseFlow(int select)
    {
        if (onPauseFlow != null)
        {
            onPauseFlow(select);
        }
    }

    //Evento muerte, en caso de que la partida deba llegar a su fin, ya sea por vida=0 u otras causas
    public event Action onDeath;

    public void death()
    {
        if (onDeath != null)
        {
            onDeath();
        }
    }

    //Evento CamScroll para el scroll de fondo cuando se mueve el personaje
    public event Action onCamScroll;

    public void camScroll()
    {
        if (onCamScroll != null)
        {
            onCamScroll();
        }
    }

    //Efecto onClick para cuando se pulsa un botón
    public event Action onClick;

    public void click()
    {
        if (onClick != null)
        {
            onClick();
        }
    }

    //Efecto take back to pool en caso de requerir devolver un objeto a su estado inactivo en la pool
    public event Action<GameObject> onTkPool;

    public void tkPool(GameObject obj)
    {
        if (onTkPool != null)
        {
            onTkPool(obj);
        }
    }


}
