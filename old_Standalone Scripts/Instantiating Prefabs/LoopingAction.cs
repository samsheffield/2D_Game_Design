using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingAction : MonoBehaviour
{
    // The delay for the coroutine
    public float loopDelay = 1f;

    // This is the prefab to clone (located in the Assets folder, not the Hierarchy)
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        // Start the Loop coroutine
        StartCoroutine(Loop());
    }

    // Looping coroutine
    private IEnumerator Loop()
    {
        // Loop forever...
        while (true)
        {
            // Wait for this many seconds and then...
            yield return new WaitForSeconds(loopDelay);

            // create a clone of the prefab in the scene
            
            // Option 1: Instantiate the prefab where this gameobject is located
            Instantiate(prefab, transform.position, Quaternion.identity);

            // Option 2: Instantiate the prefab within a random range on both the x and y axes
            //Instantiate(prefab, new Vector3(Random.Range(-4f, 4f), Random.Range(-2f, 2f), 0), Quaternion.identity);
        }
    }
}
