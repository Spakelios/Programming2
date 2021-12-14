using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsExample2_Script1 : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void OnMouseDown()
    {
        if (rb.name == "cube")
        {
            rb.AddForce(Vector3.up * 20);
        }
        else if (rb.name == "sphere")
        {
            rb.AddForce(Vector3.left * 20);
        }
        else if(rb.name == "cylinder")
        {
            rb.AddForce(Vector3.up * 20, ForceMode.Impulse);
        }
        else if (rb.name == "capsule")
        {
            rb.AddForce(Vector3.right * 20, ForceMode.Acceleration);
        }
    }
}
