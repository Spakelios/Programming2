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
        bool isWalking = anim.GetBool("isWalking");
        bool fowardPressed = Input.GetKey("w");
        
        if (!isWalking && fowardPressed)
        {
            anim.SetBool("isWalking", true);
        }

        if (isWalking && fowardPressed)
        {
            anim.SetBool("isWalking", false);
        }
    }
}
