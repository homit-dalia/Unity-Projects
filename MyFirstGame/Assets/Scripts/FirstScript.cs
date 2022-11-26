using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    public bool killPlayer;
    public float speedX, speedY, speedZ;
    void Start()
    {
        print("Start function gets called !");
        
    }

    void Update()
    {

        if (killPlayer)
        {
            Destroy(gameObject, 2);
        }

        transform.Translate(speedX, speedY, speedZ);   
    }

    void OnEnable()
    {
        print(" Inside OnEnable ");
    }

    void OnDisable()
    {
        print(" Inside OnDisable ");

    }
}
