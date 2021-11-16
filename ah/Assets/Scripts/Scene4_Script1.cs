using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene4_Script1 : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up, -50.0f * Time.deltaTime);
    }
}
