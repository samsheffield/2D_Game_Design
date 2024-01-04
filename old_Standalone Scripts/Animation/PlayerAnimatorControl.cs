using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorControl : MonoBehaviour
{
    // This script communicates to our PlayerControl script to get direction
    // Note: The direction variable in that script needs to be changed to public
    private PlayerControl playerControl;

    // Variable to reference the Animator component
    private Animator animator;

    // Variable to reference the SpriteRenderer component
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Get references to these components
        playerControl = GetComponent<PlayerControl>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Y animation
        if(playerControl.direction.y == 0)
        {
            // If there is no Y input...
            // Set the Bool Parameters we set up in the Animator to false
            // In our example this causes the Animator to transition to idle
            animator.SetBool("yWalkUp", false);
            animator.SetBool("yWalkDown", false);
        }
        else
        {
            // Else, if there is Y input...
            if(playerControl.direction.y < 0)
            {
                // If it is less than 0 set the Animator's Bool Parameter yWalkDown to true
                // In our example this causes the Animator to transition to walk down animation
                animator.SetBool("yWalkDown", true);
            }
            else if (playerControl.direction.y > 0)
            {
                // If it is greater than 0 set the Animator's Bool Parameter yWalkUp to true
                // In our example this causes the Animator to transition to walk up animation
                animator.SetBool("yWalkUp", true);
            }
        }

        // X animation
        if(playerControl.direction.x == 0)
        {
            // If there is no X input...
            // Set the Bool Parameter we set up in the Animator called xWalk to false
            // In our example this causes the Animator to transition to idle
            animator.SetBool("xWalk", false);
        }
        else
        {
            // Else, if there is X input...
            // Set the Animator's xWalk Parameter to true
            // In our example this causes the Animator to transition to the horizontal walking animation
            animator.SetBool("xWalk", true);

            // Sprite flipping is done based on direction
            // If the Input is left, set the SpriteRenderer's flipX property to true (mirror the sprite)
            //// If the Input is right, set the SpriteRenderer's flipX property to false (reset the sprite)
            if (playerControl.direction.x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if(playerControl.direction.x > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
    }
}
