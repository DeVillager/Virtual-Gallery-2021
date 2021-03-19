using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleAnimation : MonoBehaviour
{
    Animator m_Animator;
    Animator otherAnimator;
    public
 
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }
 
    void Update()
    {
        // if (otherAnimator.getTrigger == true)
        // {
        //     m_Animator.SetTrigger("Trigger");
        // }
    }
}
