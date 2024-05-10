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
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;


    // Start is called before the first frame update
    void Start()
    {
        //  spawn animals
        Invoke("SpawnRandomAnimalTop", spawnInterval);
        Invoke("SpawnRandomAnimalRight", spawnInterval + 1);
        Invoke("SpawnRandomAnimalLeft", spawnInterval + 2);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimalTop()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomSpawnInterval = Random.Range(2, 3);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Vector3 rotation = new Vector3(0, 180, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
        Invoke("SpawnRandomAnimalTop", randomSpawnInterval);
    }

    void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomSpawnInterval = Random.Range(2, 3);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
        Invoke("SpawnRandomAnimalRight", randomSpawnInterval);

    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomSpawnInterval = Random.Range(2, 3);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
        Invoke("SpawnRandomAnimalLeft", randomSpawnInterval);

    }
}
