using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static System.Numerics.Quaternion;

public class LabWork_Script1 : MonoBehaviour
{
    public Transform from;
    public Transform to;
    public float speed = 0.1f;

    private void Update()
    {
        transform.rotation = Quaternion.Slerp(@from.rotation, to.rotation, Time.time * speed);
        transform.position = Vector3.Lerp(@from.position, to.position, Time.time * speed);
    }
}
