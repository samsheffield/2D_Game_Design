using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// IMPORTANT: Needed to switch scenes
using UnityEngine.SceneManagement;

public class BasicSaveBool : MonoBehaviour
{
    // This is the name of the scene to switch to. Set in the Inspector
    // Make sure this is 1) in your Build Settings 2) Spelled correctly
    public string nextScene = "Example";

    public bool myBool;
    
    // ints are whole numbers. In this case, 1 = true and 0 = false
    private int myBoolInt;
    
    
    void Update()
    {
        // Basic example using a keypress to...
        // Save some data in PlayerPrefs
        // Switch to next scene
        if (Input.anyKeyDown == true)
        {
            // Set int based on bool value
            if (myBool == true)
            {
                myBoolInt = 1;
            }
            else
            {
                myBoolInt = 0;
            }
            
            // Save the int variable using the "MyBoolInt" key.
            // You can name this whatever you want. If it doesn't exist, Unity will create it.
            // It can retrieved later using this key.
            PlayerPrefs.SetInt("MyBoolInt", myBoolInt);
            
            SceneManager.LoadScene(nextScene);
        }
    }
}