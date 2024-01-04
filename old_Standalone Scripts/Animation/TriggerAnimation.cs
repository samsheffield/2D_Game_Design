using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    // Variable to reference the Animator component
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Get references to the Animator component
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If any key is pressed...
        if(Input.anyKeyDown == true)
        {
            // Signal the Trigger Parameter we set up in the Animator called isReady to true
            // In our example, this triggers the transition of a one shot animation from an idle state
            animator.SetTrigger("isReady");
        }
    }
}
