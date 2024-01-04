using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyingThings : MonoBehaviour
{
    // This example assumes you will use collision to destroy something. You can use the code inside of OnTriggerEnter2D as well
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If the other thing has a specific tag. It's a good idea to limit the detection to specific things
        if (collision.gameObject.CompareTag("Player") == true)
        {
            // Destroy this gameobject?
            Destroy(gameObject);

            // Destroy the gameobject this one collided with? Uncomment this next line
            //Destroy(collision.gameObject);
        }
    }
}
