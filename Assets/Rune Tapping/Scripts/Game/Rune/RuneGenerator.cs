using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuneGenerator : MonoBehaviour {

    List<GameObject> normalRunePool, xRunePool, otherPool;

    void Awake()
    {
        InitPool();    
    }

    // Update is called once per frame
    void Update () {
		
	}

    void InitPool()
    {
        normalRunePool = new List<GameObject>();
        xRunePool = new List<GameObject>();
        otherPool = new List<GameObject>();
    }

    public void AddToNormalRunePool(GameObject normalRune)
    {
        normalRunePool.Add(normalRune);
    }

    public void AddToXRunePool(GameObject xRune)
    {
        xRunePool.Add(xRune);
    }

    public void AddToOtherRunePool(GameObject otherRune)
    {
        otherPool.Add(otherRune);
    }
}
