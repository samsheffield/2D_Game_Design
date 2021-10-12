using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabEmitter : MonoBehaviour
{
    public GameObject prefab;
    public float emitRate = 1f;
    public float emitForce = 20f;
    public bool ready;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Emit());
    }

    private IEnumerator Emit()
    {
        while (true)
        {
            // If you want to toggle the emitting, use a variable that you can set true or false
            if (ready == true)
            {
                // Local variable is only available in this if() and is created new each time it is called
                GameObject p = Instantiate(prefab, transform.position, transform.rotation);

                // Get its Rigidbody2D component. Make sure it has one.
                Rigidbody2D prb2d = GetComponent<Rigidbody2D>();

                // Add force upward times force. Want it to shoot another direction? Rotate the gameobject OR
                // Experiment with transform.right etc
                prb2d.AddForce(transform.up * emitForce, ForceMode2D.Impulse);
            }

            // Wait
            yield return new WaitForSeconds(emitRate);
        }
    }
}
