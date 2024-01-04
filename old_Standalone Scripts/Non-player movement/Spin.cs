using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    // Set gravity and angular drag to 0 so there is no slow down
    public float spinVelocity = 18f;

    // A variable the Rigidbody2D component on this GameObject
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    private void Start()
    {
        // Get the Rigidbody2D component on this GameObject and save it in the rb2d variable
        rb2d = GetComponent<Rigidbody2D>();
    }

    // FixedUpdat eis for physics
    private void FixedUpdate()
    {
        // Spin at velocity
        rb2d.angularVelocity = spinVelocity;
    }
}
