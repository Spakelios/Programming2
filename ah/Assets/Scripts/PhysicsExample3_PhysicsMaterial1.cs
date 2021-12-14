using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PhysicsExample3_PhysicsMaterial1 : MonoBehaviour
{

    void Start()
    {
        PhysicMaterial rubber = new PhysicMaterial("Rubber");

        rubber.bounciness = 1.0f;

        rubber.staticFriction = 0.6f;

        rubber.dynamicFriction = 0.6f;

        GetComponent<SphereCollider>().material = rubber;

    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "enemy")
        {
            Destroy(col.gameObject);
        }

        else if (col.gameObject.name == "cube")
        {
            col.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
        }
    }

    private void Update()
    {
        bool down = Input.GetButtonDown("Fire1");

        int myDirection = Random.Range(0, 4);
        
        Vector3 myDirectionVector = new Vector3();

        switch (myDirection)
        {
            case 0:
                myDirectionVector = Vector3.forward;
                break;

            case 1:

                myDirectionVector = Vector3.back;
                break;
            case 2:

                myDirectionVector = Vector3.left;
                break;

            default:

                myDirectionVector = Vector3.right;
                break;

        }

    if (down)
                {
                    GetComponent<Rigidbody>().AddForce(myDirectionVector * 10, ForceMode.VelocityChange);
                }


        }
    }
