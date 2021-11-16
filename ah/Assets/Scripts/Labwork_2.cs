using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Labwork_2 : MonoBehaviour
{
    public Transform cube1;
    public Transform cube2;

    public float speed = 0.1f;

    private void Update()
    {
        Vector3 targetdirection = cube1.position - transform.position;

        float singleStep = speed * Time.deltaTime;

        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetdirection, singleStep, 0.0f);
        
        Debug.DrawRay(transform.position, newDirection, Color.red);
        
        transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
