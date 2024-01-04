using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    void Start()
    {
        // Put this on a gameobject that has an AudioSource component playing your background audio
        
        // This is an array. Artray hold a set of the same type of data
        // This array holds any GameObject in the scene with a "music" tag
        GameObject[] o = GameObject.FindGameObjectsWithTag("music");
        
        // If there's more than 1...
        if (o.Length > 1)
        {
            // There can be only one, so destroy this one
            Destroy(gameObject);
        }
        
        // If there isn't 1 already make it so that this gameobject isn't destroyed between scenes
        DontDestroyOnLoad(gameObject);
    }
}