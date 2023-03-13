using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject doomCube;
    private float spawnRangeX = 15;
    private float spawnPosZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 5f;
    void Start()
    {
        InvokeRepeating("SpawnMoment", startDelay, spawnInterval);
    }
    void Update()
    {

    }
    void SpawnMoment()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(doomCube, spawnpos, transform.rotation);
    }
}