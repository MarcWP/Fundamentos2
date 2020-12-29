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

    public event Action onLeverEvent;

    public void leverEvent()
    {
        if (onLeverEvent != null)
        {
            onLeverEvent();
        }
    }

    public event Action onPickUp;

    public void pickUp()
    {
        if (onPickUp != null)
        {
            onPickUp();
        }
    }

    public event Action onTakeHit;

    public void takeHit()
    {
        if (onTakeHit != null)
        {
            onTakeHit();
        }
    }

    public event Action<int> onPauseFlow;

    public void pauseFlow(int select)
    {
        if (onPauseFlow != null)
        {
            onPauseFlow(select);
        }
    }

    public event Action onDeath;

    public void death()
    {
        if (onDeath != null)
        {
            onDeath();
        }
    }

    public event Action onCamScroll;

    public void camScroll()
    {
        if (onCamScroll != null)
        {
            onCamScroll();
        }
    }


}
