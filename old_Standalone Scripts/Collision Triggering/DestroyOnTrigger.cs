using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{

    // Add this script to a ameobject which will be used to destroy anything which triggers it
    // Set this gameobject's collider to a trigger by checking the Is Trigger box in the Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroys any other gameobject with a rigidbody and collider
        // Check for a tag if you want only certain thins to be destroyed
        Destroy(collision.gameObject);
    }
}
