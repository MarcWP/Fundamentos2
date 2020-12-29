using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private Vector3 pos;
    public float empieza;
    public float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("usePool",empieza,intervalo);
    }

    // Update is called once per frame
    void usePool()
    {
        if (gameObject.GetComponent<Pooler>().pool.Count > 0)
        {
            pos= new Vector3(Random.Range(-24.0F, 24.0F), gameObject.transform.position.y, 0);
            gameObject.GetComponent<Pooler>().spawnObject(pos, gameObject.transform.rotation);
        }
        
    }
}
