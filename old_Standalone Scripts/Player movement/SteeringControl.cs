using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteeringControl : MonoBehaviour
{
    // Force of forward movement
    public float speed = 2f;

    // Velocity of rotation
    public float rotationSpeed = 100f;

    // Set this true in the inspector to allow for physics (sliding, etc). Tweak drag in the Rigidbody2D component to control 
    public bool usePhysics;

    // For storing Rigidbody2D reference
    private Rigidbody2D rb2d;

    // For passing input from Update to FixedUpdate
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        // Store the reference to the Rigidbody2D component
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Use Raw Axis values (-1,0,1) for x and y and store them in the direction variable
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        // Override physics if usePhysics is false
        if(usePhysics == false){
            rb2d.angularVelocity = 0;
            rb2d.velocity = Vector2.zero;
        }

        // Rotate the player by multiplying rotation speed and x direction and setting the angular velocity. The - is used to reverse the rotation
        rb2d.angularVelocity = -rotationSpeed * direction.x;

        // Move player forward (actually, up) relative to it's rotation with transform.up
        // The force is speed multiplied by y direction multiplied by transform up. Impulse ForceMode is used to apply it immediately
        rb2d.AddForce(speed * direction.y * transform.up, ForceMode2D.Impulse);
    }
}
