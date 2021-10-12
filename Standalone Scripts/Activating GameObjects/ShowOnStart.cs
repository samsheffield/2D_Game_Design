using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowOnStart : MonoBehaviour
{

    // Link to the gameobject in your scene
    public GameObject activateThisOne;

    // Start is called before the first frame update
    // Put any code in here that you want to run Just Once when your scene starts
    void Start()
    {

        // To set this gameobject active...
        activateThisOne.SetActive(true);

        /* Why can't you just put this directly on the gameobject itself?
         * When a gameobject is inactive, it's scripts are also inactive
         */

        /* Why might you do this instead of just keeping the active box checked in the Inspector?
         * Sometimes having something always active in your Scene View can make things cluttered
         * Sometimes we want something to happen when we spawn (instantiate) clones of a prefab
         */

        /* Why am I getting a NullReferenceError?
         * You forgot to set the public GameObject variable in the Inspector
         */
    }
}
