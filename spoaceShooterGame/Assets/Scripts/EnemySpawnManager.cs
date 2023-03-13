using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject doomCube;
    private float spawnRangeX = 60;
    private float spawnPosZ = 7;
    private float startDelay = 2;
    private float spawnInterval = .25f;
    void Start()
    {
        InvokeRepeating("SpawnMoment", startDelay, spawnInterval);
    }
    void Update()
    {

    }
    void SpawnMoment()
    {
        Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 80, spawnPosZ);
        Instantiate(doomCube, spawnpos, transform.rotation);
    }
}