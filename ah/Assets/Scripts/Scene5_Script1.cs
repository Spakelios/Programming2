using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5_Script1 : MonoBehaviour
{
    public Transform from;
    public Transform to;

    public float speed = 0.1f;

    private void Update()
    {
        transform.rotation = Quaternion.Slerp(@from.rotation, to.rotation, Time.time * speed);
        
    }
}
