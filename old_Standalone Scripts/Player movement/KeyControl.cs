using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyControl : MonoBehaviour
{
    // Variables for keycodes that can be set in the Inspector
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    // Player speed
    public float speed = 10f;

    // Variables used only within this script
    private Vector2 direction;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        // Store a reference to the rigidbody2d component to use in this script
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Since we're creating our own input controls, we need to reset them to 0 or we'll keep moving in the last pressed direction
        // IF YOU REMOVE THE LINE BELOW: You will keep moving in the last pressed direction (FUN!)
        direction = Vector2.zero;

        // Direction's x and y values are set individually to 1 or -1 to multiply later with speed
        if (Input.GetKey(up))
        {
            direction.y = 1;
        }
        if (Input.GetKey(down))
        {
            direction.y = -1;
        }

        if (Input.GetKey(right))
        {
            direction.x = 1;
        }
        if (Input.GetKey(left))
        {
            direction.x = -1;
        }
    }

    private void FixedUpdate()
    {
        // Setting velocity to zero each cycle will make movement more precise
        // NOTE: Vector2.zero is shorthand for new Vector2(0f, 0f)
        rb2d.velocity = Vector2.zero;

        rb2d.AddForce(direction * speed, ForceMode2D.Impulse);

    }
}
