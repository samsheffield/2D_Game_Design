using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAnimation : MonoBehaviour
{
    // Variable to reference the Animator component
    private Animator animator;

    // Variable to control an active state used for animation
    public bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        // Get references to the Animator components
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If any key is pressed...
        if (Input.anyKeyDown == true)
        {
            // Invert isActive (true becomes false, false becomes true)
            isActive = !isActive;
        }

        // Use the isActive variable to set the isActive Bool Parameter we set up in the Animator
        animator.SetBool("isActive", isActive);
    }
}
