using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackForth : MonoBehaviour
{
    // 1 = right, -1 = left
    private float xDirection = 1;

    // How fast to move
    public float xVelocity = 5f;

    // Distance to travel before reversing
    public float xDistance = 1f;

    // This is needed to get baseline for movement
    private float startX;

    // Variable to set the Rigidbody
    private Rigidbody2D rb2d;

    private void Start()
    {
        // Set to position on x axis when starting
        startX = transform.position.x;

        // Get the Rigidbody2D component on this GameObject
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if x position is greater than the distance from the start
        if(transform.position.x > startX + xDistance)
        {
            // If so, go left
            xDirection = -1;
        }
        else if(transform.position.x < startX - xDistance){
            // Check to see if x position is less than the distance from the start and go right
            xDirection = 1;
        }
    }

    private void FixedUpdate()
    {
        // zero out velocity to keep from sliding
        rb2d.velocity = Vector2.zero;

        // Only move on the x axis. Vector2 (x, y)
        rb2d.AddForce(new Vector2(xDirection * xVelocity, 0), ForceMode2D.Impulse);
    }
}
