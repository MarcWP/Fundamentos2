using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{

    public GameObject objectToPool;
    public List<GameObject> pool = new List<GameObject>();
    public int startAmount;
    private Vector3 pos;
    public float empieza;
    public float intervalo;

    
    private void Start()
    {
        //Preparamos objetos predefinidos del pool
        for (int i = 0; i < startAmount; i++)
        {
            pool.Add(Instantiate(objectToPool));
            pool[i].SetActive(false);
            pool[i].transform.parent = transform;
        }
        //Suscribimos al evento de desactivación de objetos
        GameEvent.current.onTkPool += returnObject;
        //Repetimos invocación de objetos desde la pool
        InvokeRepeating("usePool", empieza, intervalo);
    }

    //Instanciamiento de objetos desde el pool
    private GameObject spawnObject(Vector3 position, Quaternion rotation)
    {
        GameObject toReturn;

        if(pool.Count > 0)
        {
            toReturn = pool[0];
            pool.RemoveAt(0);
        }
        else
        {
            toReturn = Instantiate(objectToPool);
            toReturn.transform.parent = transform;
        }

        toReturn.SetActive(true);
        toReturn.transform.position = position;
        toReturn.transform.rotation = rotation;

        return toReturn;
    }

    //Método para devolución de objetos al pool
    private void returnObject(GameObject objectToReturn)
    {
        pool.Add(objectToReturn);
        objectToReturn.SetActive(false);
    }

    //El enemigo se invocará dentro de un area predefinida, activándolo desde un pool
    void usePool()
    {
        if (gameObject.GetComponent<Pooler>().pool.Count > 0)
        {
            pos = new Vector3(Random.Range(-24.0F, 24.0F), gameObject.transform.position.y, 0);
            gameObject.GetComponent<Pooler>().spawnObject(pos, gameObject.transform.rotation);
        }

    }
}
