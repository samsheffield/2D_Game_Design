using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicLoadBool : MonoBehaviour
{
    // Used to store the retrieved data from PlayerPrefs
    // ints are whole numbers. 
    private int myBoolInt;
    
    public bool myBool;

    // Start is called before the first frame update
    void Start()
    {
        // Retrieve an int stored with the "MyBoolInt" key and use it to set the bool. 
        // // In this case, 1 = true and 0 = false.
        // If it doesn't exist it will be ignored.
        if (PlayerPrefs.GetInt("MyBoolInt") == 1)
        {
            myBool = true;
        }
        else
        {
            myBool = false;
        }
        
        Debug.Log(myBool);
    }

}
