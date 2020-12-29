using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0f;
        GameEvent.current.onPauseFlow += pauseControl;
    }

    private void pauseControl(int select)
    {
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
