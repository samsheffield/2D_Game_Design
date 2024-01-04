using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    // Link to the Player gameobject's Transform component because we want the position
    public Transform playerTransform;

    // Variable to store the player's start position
    private Vector2 playerStartPosition;

    // Start is called before the first frame update. This runs only once at the start of the scene
    void Start()
    {
        // Store the player's transform position at the start of the scene
        // This way we can return to it at any point later on
        playerStartPosition = playerTransform.position;
    }

    // Make sure this collider has Is Trigger checked or this will not work
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Check for the Player tag
        if (collision.gameObject.CompareTag("Player"))
        {
            // Now do the reverse from before...
            // Set the player's transform position TO the player start position variable
            playerTransform.position = playerStartPosition;
        }
        
    }
}
