﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
    public int x;
    public string text;
    
    // Start is called before the first frame update
    void Start()
    {
        /* 
        if (x>0)
    {
        Debug.Log("x ist größer als 0");
    }
    else 
    {
        Debug.Log("x ist kleiner als 0");
    }
    if (text == "HUBI")
    {
        Debug.Log("In der text Variable steht HUBI");
    }
    else
    {
        Debug.Log("In der text Variable steht etwas anderes");
    }
    }

    // Update is called once per frame
    void Update() 
    {
        */
    
    if (x > 10) {
        Debug.Log("x ist größer oder gleich als 10");
    }

    }
}
