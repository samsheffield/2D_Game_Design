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
        // Check if not already emitting something AND the Fire1 button has been pressed and held down
        // Fire1 refers to Left mouse click and Left Ctrl. Consider changing this to Input.GetKey() to customize
        // Multiple conditions can be tested using && operator. All conditions must be true
        if(isActive == false && Input.GetButton("Fire1"))
        {
            StartCoroutine(AutoEmit());
            isActive = true;
        }
    }

    // Coroutine for emitting projectile
    private IEnumerator AutoEmit()
    {
        while(true){
            GameObject p = Instantiate(prefab, transform.position, transform.rotation);
            Rigidbody2D prb2d = GetComponent<Rigidbody2D>();
            prb2d.AddForce(transform.up * emitForce);
            yield return new WaitForSeconds(emitRate);
        }
    }
}