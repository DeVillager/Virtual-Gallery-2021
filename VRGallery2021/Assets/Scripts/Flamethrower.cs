using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Flamethrower : MonoBehaviour
{
    public GameObject flamethrower;
    public Transform barrelPivot;
    public float shootingSpeed = 1;
    public GameObject muzzleFlash;

    private Animator animator;
    // private Interactable interactable;

    void Start()
    {
        flamethrower.SetActive(false);
        // interactable = GetComponent<Interactable>();
    }

    void Update()
    {
        // if (interactable.attachedToHand != null)
        // {
        //     SteamVR_Input_Sources source = interactable.attachedToHand.handType;
        //     if (fireAction[source].stateDown)
        //     {
        //         //Fire();
        //         flamethrower.SetActive(true);
        //     }
        //     else if (fireAction[source].stateUp)
        //     {
        //         flamethrower.SetActive(false);
        //     }
        // }
    }

    void Fire()
    {
        Debug.Log("Fire");
        flamethrower.SetActive(true);
    }
}
