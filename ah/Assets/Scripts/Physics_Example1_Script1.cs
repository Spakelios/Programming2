using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Physics_Example1_Script1 : MonoBehaviour
{
    private bool gravity = true;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Rigidbody rb2 = GameObject.Find("Sphere").GetComponent<Rigidbody>();
        Rigidbody rb3 = GameObject.Find("Capsule").GetComponent<Rigidbody>();

        rb.useGravity = true;
        rb2.useGravity = true;
        rb3.useGravity = true;

        rb2.drag = 10;
        rb3.mass = 0.001f;
    }

    public void toggleGravity()
    {
        if (gravity)
        {
            Physics.gravity = new Vector3(0, 9.8f, 0);
            gravity = false;
        }
        else
        {
            Physics.gravity = new Vector3(0, -9.8f, 0);
            gravity = true;
        }
    }
}

//     private void FixedUpdate()
//     {
//         rigidbody.AddForce(Vector3.up * 20);
//         rigidbody.AddForce(Vector3.left * 10, ForceMode.VelocityChange);
//         rigidbody.AddForce(Vector3.right * 10, ForceMode.Acceleration);
//         rigidbody.AddForce(Vector3.down * 100, ForceMode.Impulse);
//     }
// }
