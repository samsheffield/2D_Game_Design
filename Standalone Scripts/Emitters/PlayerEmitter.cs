using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEmitter : MonoBehaviour
{
    // Prefab from the Assets folder that will be used as a projectile
    public GameObject prefab;
    // How fast to emit it
    public float emitForce = 50f;
    
    // Update is called once per frame
    private void Update() {
        // Fire1 refers to Left mouse click and Left Ctrl. Consider changing this to Input.GetKey() to customize
        if(Input.GetButton("Fire1"))
        {
            GameObject p = Instantiate(prefab, transform.position, transform.rotation);
            Rigidbody2D prb2d = GetComponent<Rigidbody2D>();
            prb2d.AddForce(transform.up * emitForce);
        }
    }
}