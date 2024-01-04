using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedAction : MonoBehaviour
{
    // Delay variables
    public float startDelay = 3f;
    public float actionDelay = 2f;

    // This is used by the script to ensure a coroutine is only done once in Update
    private bool delayedActionHappened = false;


    // Update is called once per frame
    void Update()
    {
        // Only start a coroutine once in Update
        // Give it some condition to test...
        if (Input.GetKeyUp(KeyCode.Space))
        {
            // Only run this code if it hasn't already been run
            if (delayedActionHappened == false)
            {
                // Keeps from starting the coroutine over and over again
                delayedActionHappened = true;

                // Start coroutine
                StartCoroutine(DelayAction());
            }
        }

        // Start a coroutine whenever a condition occurs
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Just be careful not to generate a bunch of endlessly looping coroutines!
            StartCoroutine(DelayActionRepeat());
        }
    }

    private IEnumerator DelayAtStart()
    {
        // Wait this long...
        yield return new WaitForSeconds(startDelay);

        // Then do this
        Debug.Log("Start Delay over");
    }

    private IEnumerator DelayAction()
    {
        Debug.Log("Action started");
        yield return new WaitForSeconds(actionDelay);
        Debug.Log("Action completed");
    }

    private IEnumerator DelayActionRepeat()
    {
        Debug.Log("Repeat action started");
        yield return new WaitForSeconds(actionDelay);
        Debug.Log("Repeat action completed");
    }
}
