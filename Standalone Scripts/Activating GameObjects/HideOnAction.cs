using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnAction : MonoBehaviour
{
    // You can set this to another key in the Inspector
    public KeyCode hideKey = KeyCode.Space;

    // Update is called once per frame
    // Add any code here that needs to loop Constantly
    void Update()
    {

        // Check to see if some condition is true...
        if(Input.GetKeyUp(hideKey) == true)
        {
            // ... then hide this gameObject by deactivating it
            gameObject.SetActive(false);

            /* Why isn't my code running once I deactivate this gameobject?
             * Scripts and other components will also be deactivated
             */

            /* Why gameObject and not GameObject?
             * gameObject refers to This One while GameObject means the entire class of gameobjects
             */

            /* What if I want something else to trigger this to deactivate?
             * Use a bool variable and do something to eventually set that true
             * Replace the input condition in if() to check your variable like if(gameOver == true)
             * */
        }
    }
}
