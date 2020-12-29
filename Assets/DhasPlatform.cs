using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DhasPlatform : MonoBehaviour
{
    public float force;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="jugador")
        {
            collision.rigidbody.AddForce(Vector3.right * force);
        }
    }
}
