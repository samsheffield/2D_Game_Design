using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // This is a gameobject that becomes active when triggering a particular tag 
    public GameObject alert;

    // This is a boolean which keeps track of the player's interaction state. When true, a player can use input to do something in Update
    public bool canInteract;

    private void Update()
    {
        // If both canInteract AND Fire1 is pressed...
        if(canInteract == true && Input.GetButtonDown("Fire1"))
        {
            // Do something more interesting than this!
            Debug.Log("IT HAPPENED!");
        }
    }

    // This happens when entering a triggered state
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Filter triggering based on tags (example: Home and Button)
        if (collision.gameObject.CompareTag("Home"))
        {
            // This example sets the alert gameobject active if the trigger's tag is Home
            alert.SetActive(true);
        }
        else if (collision.gameObject.CompareTag("Button"))
        {
            // This example sets the canInteract state true if the trigger's tag is Button. Input is now possible in Update
            canInteract = true;
        }
    }

    // This happens when exiting a triggered state
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Filter triggering based on tags (example: Home and Button)
        if (collision.gameObject.CompareTag("Home"))
        {
            // This example sets the alert gameobject inactive if the trigger's tag is Home
            alert.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Button"))
        {
            // This example sets the canInteract state false if the trigger's tag is Button. No more input is possible in update
            canInteract = false;
        }
    }
}
