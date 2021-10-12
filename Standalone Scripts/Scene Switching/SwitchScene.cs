using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Add Scene Management

public class SwitchScene : MonoBehaviour
{

    // Important: Don't forget to add the next scene to your project's Build Settings

    // Set the name of the Scene you want to switch to in the Inspector
    public string nextScene;

    // Keys that can be set in the Inspector
    public KeyCode switchKey = KeyCode.Space;
    public KeyCode quitKey = KeyCode.Escape;

    // Update is called once per frame
    void Update()
    {
        // If this key is pressed and released...
        if(Input.GetKeyUp(switchKey) == true)
        {
            // Load next scene
            SceneManager.LoadScene(nextScene);
        }

        // If this key is pressed
        if (Input.GetKeyUp(quitKey) == true)
        {
            // Quit game
            Application.Quit();
        }
    }
}
