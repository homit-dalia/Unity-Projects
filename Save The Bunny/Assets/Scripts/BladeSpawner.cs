using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeSpawner : MonoBehaviour
{
    public GameObject blade;
    float xPositionLimit = 2.66f;   
    public float spawnRate;
    float randomX;
    Vector2 spawnPosition;

    void Start()
    {
        StartSpawning();
    }

    void Update()
    {
        
    }

    void SpawnBlade()
    {
        randomX = Random.Range(-xPositionLimit, xPositionLimit);
        spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(blade, spawnPosition, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnBlade", 3f, spawnRate);
    }

    void StopSpawning()
    {
        CancelInvoke("SpawnBlade");
    }
}
