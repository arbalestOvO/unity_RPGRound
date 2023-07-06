using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.Utilities.Editor;
using UnityEngine;

[Serializable] public class Pool
{ 
    private Queue<GameObject> q;
    [SerializeField] private int initSize;
    [SerializeField] public GameObject prefab;
    public void Initial()
    {
        q = new Queue<GameObject>();
        for (int i = 0; i < initSize; i++)
        {
            Copy();
        }
    }
    void Copy()
    {
        var gameObject = GameObject.Instantiate(prefab);
        gameObject.name = prefab.name;
        gameObject.SetActive(false);
        q.Enqueue(gameObject);
    }

    public GameObject GetObject()
    {
        GameObject res = null;
        if (q.Count == 0)
            Copy();
        res = q.Dequeue();
        res.SetActive(true);
        return res;
    }
    public void Disable(GameObject gameObject)
    {
        gameObject.SetActive(false);
        q.Enqueue(gameObject);
    }
}
