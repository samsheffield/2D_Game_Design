using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add SceneManagement to switch scenes
using UnityEngine.SceneManagement;

public class TriggerScene : MonoBehaviour
{
    // Create a string variable that you can set in the Inspector to specify the name of your new scene. You don't need quotes there.
    public string newScene;

    // OnTriggerEnter2D is called at the moment of intersection
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the other thing has a specific tag. It's a good idea to limit the detection to specific things
        if (collision.gameObject.CompareTag("Player") == true)
        {
            SceneManager.LoadScene(newScene);
        }
    }
}
