using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_Script1 : MonoBehaviour
{
    public Transform cube2;
    public float dotProduct;
    public Vector3 cubeRotation;
    public Vector3 cube2Rotation;

    private void Update()
    {
        cubeRotation = transform.forward;
        cube2Rotation = cube2.forward;
        dotProduct = Vector3.Dot(cubeRotation, cube2Rotation);

        if (dotProduct == 1)
        {
            print("cubes will face same direction");
        }
        else if (dotProduct == -1)
        {
            print("cubes will face opposite directions");
        }
    }
}
