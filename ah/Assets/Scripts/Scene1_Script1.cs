using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_Script1 : MonoBehaviour
{
    Vector3 OriginVector = new Vector3 (0, 0, 0);
    private float xPos;
    private float currentDistance;
    void Update()
    {
        xPos = transform.position.x;
        transform.position = new Vector3(xPos + 0.1f, 0, 0);
        currentDistance = Vector3.Distance(OriginVector, transform.position);
        Debug.Log("Current Distance from origin: " + currentDistance);
    }
}
