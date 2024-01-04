using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IMPORTANT: Needed to switch scenes
using UnityEngine.SceneManagement;

public class BasicSave : MonoBehaviour
{
    // This is the name of the scene to switch to. Set in the Inspector
    // Make sure this is 1) in your Build Settings 2) Spelled correctly
    public string nextScene = "Example";
    public float myFloat;
    
    void Update()
    {
        // Basic example using a keypress to...
        // Save some data in PlayerPrefs
        // Switch to next scene
        if (Input.anyKeyDown == true)
        {
            // Save the float variable using the "MyFloat" key.
            // You can name this whatever you want. If it doesn't exist, Unity will create it.
            // It can retrieved later using this key.
            PlayerPrefs.SetFloat("MyFloat", myFloat);
            SceneManager.LoadScene(nextScene);
        }
    }
}
