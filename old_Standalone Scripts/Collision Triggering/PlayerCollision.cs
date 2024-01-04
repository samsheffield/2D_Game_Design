using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // This is the point value for the key item
    public float itemValue = 1f;

    // This is the audio file you want to play for the key item. Set it in the Inspector
    public AudioClip itemSoundClip;

    // An audio source variable that is only going to be used in this script
    private AudioSource audioSource;

    private void Start()
    {
        // Store a reference to this gameobject's audio source component
        audioSource = GetComponent<AudioSource>();
    }

    // This happens when a trigger collision takes place (Is Trigger checked on one collider)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // If the collider's gameobject's tag is Item...
        if (collision.gameObject.CompareTag("Item") == true)
        {
            // Play the key item sound once
            audioSource.PlayOneShot(itemSoundClip);

            // Update the score in a game manager/level manager here
            
            // Destroy the other gameObject
            Destroy(collision.gameObject);
        }
    }
}
