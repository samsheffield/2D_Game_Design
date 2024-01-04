using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustOnce : MonoBehaviour
{

    // Has the thing already been done?
    private bool alreadyDone = false;


    // Update is called once per frame
    void Update()
    {

        // Signal that it's time to do something only once. In this example, press Space
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {

            // Only run the code in this if alreadyDone is false
            if(alreadyDone == false)
            {
                // Do this thing only once and then...
                Debug.Log("Just Once");

                // Set this true to keeps the enclosing if() statement from being able to run again
                alreadyDone = true;
            }
        }
    }
}
