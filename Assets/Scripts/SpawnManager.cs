using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Variables
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 0.5f;

    //Definition of Random Spawn Animal
     void SpawnRandomAnimal() {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0,animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    // Start is called before the first frame update
    void Start()
    {
        //Spawn Animal
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
