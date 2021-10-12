using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdvancedSpawner : MonoBehaviour {

    // Link to the prefab you want to instantiate
    public GameObject prefab;

    // Timings
    public float delay = 1f;
    public float spawnRate = 1f;

    // Random
    public bool randomSpawn;
    public float minSpawnRate = 1f;
    public float maxSpawnRate = 5f;


    // Use this for initialization
    void Start()
    {
        // Start the coroutine
        StartCoroutine(SpawnPrefab());
    }

    private IEnumerator SpawnPrefab()
    {
        // Create a delay befor looping begins
        yield return new WaitForSeconds(delay);

        // Loop forever
        while (true)
        {
            // Instantiate prefab
            Instantiate(prefab, transform.position, Quaternion.identity);

            // Coroutine that instantiates a prefab clone in a loop at a specified rate, with an option for randomizing
            if (randomSpawn == false)
            {
                yield return new WaitForSeconds(spawnRate);
            }
            else
            {
                // Randomize the instantiation rate
                float randomSpawnRate = Random.Range(minSpawnRate, maxSpawnRate);
                yield return new WaitForSeconds(randomSpawnRate);
            }
        }
    }
}
