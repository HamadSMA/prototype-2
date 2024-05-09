using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    // public float spawnDelay;
    public float spawnInterval;
    public float spawnPosX;
    public float spawnPosZ;
    // Start is called before the first frame update
    void Start()
    {
        //  spawn animals
        Invoke("SpawnAnimal", spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 180, 0));
        spawnInterval = Random.Range(1, 3);
        Invoke("SpawnAnimal", spawnInterval);
    }
}
