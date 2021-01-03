using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class VibrationOnClick : MonoBehaviour
{
    private float freq;
    private float amp;
    private CinemachineVirtualCamera vcam;

    private void Start()
    {
        vcam = gameObject.GetComponent<CinemachineVirtualCamera>();

    }

    //Mientras pulsamos el click izquierdo la camara vibra
    private void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 1f;
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 1f;
        }
        else
        {
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0f;
            vcam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0f;
        }
        
    }
}
