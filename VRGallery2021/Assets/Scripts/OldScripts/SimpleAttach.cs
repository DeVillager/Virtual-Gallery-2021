﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAttach : MonoBehaviour
{
    public float pivotOffset = 0f;

    private void Start()
    {
        // interactable = GetComponent<Interactable>();
    }

    // private void OnHandHoverBegin(Hand hand)
    // {
    //     //hand.ShowGrabHint();
    // }
    //
    // private void OnHandHoverEnd(Hand hand)
    // {
    //     //hand.HideGrabHint();
    // }


    // private void HandHoverUpdate(Hand hand)
    // {
    //     GrabTypes grabType = hand.GetGrabStarting();
    //     bool isGrabbing = hand.IsGrabEnding(gameObject);
    //
    //     if (interactable.attachedToHand == null && grabType != GrabTypes.None)
    //     {
    //         if (pivotOffset != 0)
    //         {
    //             //hand.AttachObject(gameObject, grabType, Hand.AttachmentFlags.SnapOnAttact, attachmentOffset);
    //         }
    //         else
    //         {
    //             hand.AttachObject(gameObject, grabType);
    //         }
    //         hand.HoverLock(interactable);
    //         hand.HideGrabHint();
    //     }
    //     else if (isGrabbing)
    //     {
    //         hand.DetachObject(gameObject);
    //         hand.HoverUnlock(interactable);
    //     }
    // }

    public void ApplyGravity()
    {
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
    }

}
