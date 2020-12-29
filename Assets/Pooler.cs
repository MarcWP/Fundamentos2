using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    /*[System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public static Pooler Instance;

    private void Awake()
    {
        Instance = this;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    private void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();

        foreach (Pool pool in pools)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.size; i++)
            {
                GameObject obj = Instantiate(pool.prefab);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
            }

            poolDictionary.Add(pool.tag, objectPool);
        }
    }

    public GameObject spawnFromPool (string tag, Vector3 position, Quaternion rotation)
    {
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool con tag "+tag+" no existe.");
            return null;
        }

        GameObject objectToSpawn=poolDictionary[tag].Dequeue();
        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }*/

    public GameObject objectToPool;
    public List<GameObject> pool = new List<GameObject>();
    public int startAmount;

    private void Start()
    {
        for (int i = 0; i < startAmount; i++)
        {
            pool.Add(Instantiate(objectToPool));
            pool[i].SetActive(false);
            pool[i].transform.parent = transform;
        }
    }

    public GameObject spawnObject(Vector3 position, Quaternion rotation)
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

    public void returnObject(GameObject objectToReturn)
    {
        pool.Add(objectToReturn);
        objectToReturn.SetActive(false);
    }
}
