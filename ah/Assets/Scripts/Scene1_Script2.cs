using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_Script2 : MonoBehaviour
{
    Vector3 OriginVector = new Vector3 (0, 0, 0);
    private float zPos;
    private float currentDistance;
    private float angleBetweenObjects;
    private GameObject otherObject;
    private void Start()
    {
        otherObject = GameObject.Find("Cube1");
    }

    void Update()
    {
        zPos = transform.position.z;
        transform.position = new Vector3( 0, 0, zPos + 0.1f);
        currentDistance = Vector3.Distance(otherObject.transform.position,transform.position);
        Debug.Log("Current Distance from origin: " + currentDistance);
        angleBetweenObjects = Vector3.Angle(otherObject.transform.position, transform.position);
        Debug.Log("angle between cubes is " + angleBetweenObjects);
    }
}

