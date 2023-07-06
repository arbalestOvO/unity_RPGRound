using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PoolManager : Singleton<PoolManager>
{
    [SerializeField] private SerializedDictionary<string, Pool> dic;

    private void Awake()
    {
        foreach (var p in dic)
        {
            p.Value.Initial();
        }
    }

    public GameObject GetAObject(string name)
    {
        return dic[name].GetObject();
    }
    public void Disable(string name, GameObject gameObject)
    {
        dic[name].Disable(gameObject);
    }
}
