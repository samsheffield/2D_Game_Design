using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyControl : MonoBehaviour
{
    // Variables which can be modified in the Inspector
    public float xSpeed = .5f;
    public float flapForce = 10f;

    // Variables used only within this script
    private Vector2 direction;
    private Rigidbody2D rb2d;
    private bool flap;

    private void Start()
    {
        // Set this gameobject's tag to Player. You can also do this in the Inspector
        gameObject.tag = "Player";

        // Store a reference to the rigidbody2d component to use in this script
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // Notice that only the x property is being set to an input's value (y is 0)
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);

        // Check for a button press. "Jump" is the spacebar on a keyboard
        if (Input.GetButtonDown("Jump") == true)
        {
            // if it is true... set the flap state so that it can be used in FixedUpdate
            flap = true;
        }
    }

    // FixedUpdate is for physics
    private void FixedUpdate()
    {
        // Add an instant forces to the rigidbody2d. The forces are the input values * the xSpeed value
        // Impulse applies forces immediately, which is not very realistically, but works great for a simple 2D game
        rb2d.AddForce(direction * xSpeed, ForceMode2D.Impulse);

        // If the flap state is true... Flap!
        if(flap == true)
        {
            // AddForce always expects a Vector2 of force (x and y axes!) Vector2.up is shorthand for new Vector2(0f, 1f), so multiplying times flapForce only applies the for e on the y axis.
            rb2d.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);

            // Reset the flap state to false so we don't keep flapping
            flap = false;
        }
        
    }

}
