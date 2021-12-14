using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereMovement : MonoBehaviour
{
    public Slider slider;
    private Rigidbody rigid;

    [SerializeField] private float _speed = 10f;
    [SerializeField] private double _maximumVelocity = 10f;

    private void Awake() => rigid = GetComponent<Rigidbody>(); 

    private void FixedUpdate()
    {
        if (rigid.velocity.magnitude >= _maximumVelocity)
            return;

        if (Input.GetKey(KeyCode.W))
            rigid.AddForce(_speed * transform.forward); // move forward with w

        if (Input.GetKey(KeyCode.S))
            rigid.AddForce(_speed * -transform.forward); // -foward force goes back with s

        if (Input.GetKey(KeyCode.D))
            rigid.AddForce(_speed * transform.right); // move right with d

        if (Input.GetKey(KeyCode.A))
            rigid.AddForce(_speed * -transform.right); //- right force goes left with a
    }

  
        public void speedwagon()
        {
            _speed = slider.value * 100f;
        }

    }
