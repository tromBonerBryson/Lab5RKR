using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //private float spawnRangeX= 15;
    //private float spawnPosZ = 20;
    public GameObject animalPrefabs;
    private float startDelay = 2;
    public float spawnInterval ;
    private float left = -6.0f;
    private float right = 35.0f;
    

    // Update is called once per frame
    void Start()
    {
       InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    void Update()
    {
        
        
    }

    void SpawnRandomAnimal(){
        //spawnInterval = Random.Range(1, 4);
        Vector3 spawnPos = new Vector3(15, 0, Random.Range(left, right));
        //int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs, spawnPos, animalPrefabs.transform.rotation);
    }

   
}
