using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance { get; private set; }
    public GameObject objectPrefab;
    public int poolSize = 5;
    private List<GameObject> pool;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            InitializePool();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void InitializePool()
    {
        pool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(objectPrefab);
            obj.SetActive(false);
            pool.Add(obj);
        }
    }

    public GameObject GetObjectFromPool()
    {
        foreach (var obj in pool)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }

        // Si no hay objetos disponibles, se crea uno nuevo
        GameObject newObj = Instantiate(objectPrefab);
        pool.Add(newObj);
        return newObj;
    }
}
