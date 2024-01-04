using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomFunctionExample : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            // Call a custom function by name
            SayHi();
        }
    }

    // Custom Function!
    // Uses the same pattern as the functions which are built-in
    // These work great for Animation Events
    public void SayHi()
    {
        Debug.Log("HI!");
    }
}
