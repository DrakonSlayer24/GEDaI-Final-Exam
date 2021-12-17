using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool SharedInstance;
    public List<GameObject> PooledObject;
    public GameObject ObjectToPool;
    public int PoolAmount;

    private void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        PooledObject = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < PoolAmount; i++)
        {
            tmp = Instantiate(ObjectToPool);
            tmp.SetActive(false);
            PooledObject.Add(tmp);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < PoolAmount; i++)
        {
            if (!PooledObject[i].activeInHierarchy)
            {
                return PooledObject[i];
            }
        }

        return null;
    }
}
