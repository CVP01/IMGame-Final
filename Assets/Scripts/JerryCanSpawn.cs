using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JerryCanSpawn : MonoBehaviour
{
    public GameObject[] JerryPrefabs;
    private float spawnRangeX = 9;
    private float spawnPosZ = 179;
    private float startDelay = 8;
    private float spawnInterval = 12.0f;
    void Start()
    {
        InvokeRepeating("SpawnRandomJerry", startDelay, spawnInterval);
    }



    void Update()
    {

    }


    void SpawnRandomJerry()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int JerryIndex = Random.Range(0, JerryPrefabs.Length);
        Instantiate(JerryPrefabs[JerryIndex], spawnPos, JerryPrefabs[JerryIndex].transform.rotation);

    }
}
