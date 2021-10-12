using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    // Variables which can be modified in the Inspector
    public float speed = 7;

    // Variables used only within this script
    private Vector2 direction;
    private Rigidbody2D rb2d;

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
        // Store the values of the input axes in a Vector2 to use later
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    // FixedUpdate is for physics
    private void FixedUpdate()
    {
        // Set the rigidbody2d velocity property to 0,0 (this stops movement)
        rb2d.velocity = Vector2.zero;
        

        // Add an instant forces to the rigidbody2d. The forces are the input values * the speed value
        rb2d.AddForce(direction * speed, ForceMode2D.Impulse);
    }

}
