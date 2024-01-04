using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLoad : MonoBehaviour
{
    // Used to store the retrieved data from PlayerPrefs
    public float myFloat;

    // Start is called before the first frame update
    void Start()
    {
        // Retrieve a float stored with the "MyFloat" key
        // If it doesn't exist it will be ignored
        myFloat = PlayerPrefs.GetFloat("MyFloat");
        
        Debug.Log(myFloat);
    }

}
