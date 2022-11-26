using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;
    int i = 0;

    void Start()
    {
        foreach( GameObject o in objects)
        {
            if (i > 3)
            {
                i = 0;
            }            
                o.GetComponent<Renderer>().material.color = colors[i];
                i++;

        }
    }

    void Update()
    {
        
    }
}
