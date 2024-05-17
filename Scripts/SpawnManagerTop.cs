using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerTop : MonoBehaviour
{
    public GameObject animalPrefabs;
    private float startDelay ;
    public float spawnInterval;
    private float left = -6.0f;
    private float right = 35.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //spawnInterval = Random.Range(1, 4);
    }

    void SpawnRandomAnimal(){
        Vector3 spawnPos = new Vector3(-15, 0, Random.Range(left, right));
        Instantiate(animalPrefabs, spawnPos, animalPrefabs.transform.rotation);
    }
}
