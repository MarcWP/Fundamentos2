using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftBarrier : MonoBehaviour
{

    public float speed;
    public Vector3 startPos;
    private float lerpDuration;
    private float timeElapsed;


    private void Start()
    {
        GameEvent.current.onPickUp += liftBarrier;
        startPos = transform.position;
        timeElapsed = 0;
    }

    private void liftBarrier()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 8.7f, transform.position.z);


    }

}
