using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add the namespace to work with scenes
using UnityEngine.SceneManagement;

public class ObstacleCheck : MonoBehaviour
{

    // This happens when a collision takes place
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the collider's gameobject's tag is player...
        if (collision.gameObject.CompareTag("Player") == true)
        {
            // Load the current active scene (restart scene)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
