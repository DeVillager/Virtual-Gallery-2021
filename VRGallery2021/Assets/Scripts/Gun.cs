﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public Transform barrelPivot;
    public float shootingSpeed = 1;
    public GameObject muzzleFlash;

    // private Interactable interactable;

    void Start()
    {
        // interactable = GetComponent<Interactable>();
    }

    void Update()
    {
        // if (interactable.attachedToHand != null)
        // {
        //     SteamVR_Input_Sources source = interactable.attachedToHand.handType;
        //     if (fireAction[source].stateDown)
        //     {
        //         Fire();
        //     }
        // }
    }

    void Fire()
    {
        Debug.Log("Fire");
        Bullet bulletSc = Instantiate(bullet, barrelPivot.position, barrelPivot.rotation).GetComponent<Bullet>();
        bulletSc.SetSpeed(shootingSpeed);
    }
}
