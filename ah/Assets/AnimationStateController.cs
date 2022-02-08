using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        bool isRunning = anim.GetBool("isRunning");
        bool isWalking = anim.GetBool("isWalking");
        bool fowardPressed = Input.GetKey("w");
        bool RunToggled = Input.GetKey("q");
        
        if (!isWalking && fowardPressed)
        {
            anim.SetBool("isWalking", true);
        }

        else if (isWalking && fowardPressed)
        {
            anim.SetBool("isWalking", false);
        }

        if (!isRunning && RunToggled)
        {
            anim.SetBool("isRunning", true);
        }
       
        else if (isRunning && RunToggled)
        {
            anim.SetBool("isRunning", false);
        }
    }
}
