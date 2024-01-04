using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCheck : MonoBehaviour
{
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
        // If the collider's gameobject's tag is Player...
        if (collision.gameObject.CompareTag("Player") == true)
        {
            // Play the audio source component's audio clip once
            audioSource.PlayOneShot(audioSource.clip);
        }
    }

}
