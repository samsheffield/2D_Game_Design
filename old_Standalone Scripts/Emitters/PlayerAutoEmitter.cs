using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAutoEmitter : MonoBehaviour
{
    // Prefab from the Assets folder that will be used as a projectile
    public GameObject prefab;
    // How fast to emit it
    public float emitForce = 50f;

    // Interval for emitting
    public float emitRate = .5f;

    // This is used to check if the GameObject is already emitting something. Used for timing
    private bool isActive;
    
    // Update is called once per frame
    private void Update() {
        // Check if not already emitting something AND the Fire1 button has been pressed
        // Fire1 refers to Left mouse click and Left Ctrl. Consider changing this to Input.GetKey() to customize
        // Multiple conditions can be tested using && operator. All conditions must be true
        if (Input.GetButtonDown("Fire1") && isActive == false)
        {
            StartCoroutine(AutoEmit());
            isActive = true;
        }

        // Stop all coroutines on this script once button is released and reset isActive to false
        // Setting isActive to false means that we can use the if() above once again
        if (Input.GetButtonUp("Fire1"))
        {
            StopAllCoroutines();
            isActive = false;
        }
    }

    // Coroutine for emitting projectile
    private IEnumerator AutoEmit()
    {
        while(true){
            GameObject p = Instantiate(prefab, transform.position, transform.rotation);
            Rigidbody2D prb2d = p.GetComponent<Rigidbody2D>();
            prb2d.AddForce(transform.up * emitForce, ForceMode2D.Impulse);

            yield return new WaitForSeconds(emitRate);
        }
    }
}