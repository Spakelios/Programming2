using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController2 : MonoBehaviour
{
    public Animator anim;
    private float Velocity = 0.0f;
    public float accelleration = 0.1f;
    private int VelocityHash;
    
    void Start()
    {
        anim = GetComponent<Animator>();

        VelocityHash = Animator.StringToHash("velocity");
    }
    
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("q");

        if (forwardPressed)
        {
            Velocity += Time.deltaTime * accelleration;
        }
        
        anim.SetFloat(VelocityHash, Velocity);
    }
}
