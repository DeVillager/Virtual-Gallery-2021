using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class WaterGun : MonoBehaviour
{
    public ParticleSystem waterEffect;
    private AudioSource audioSource;
    // public bool grabbed = false;

    void Start()
    {
        waterEffect.Stop();
        audioSource = GetComponent<AudioSource>();
    }

    // protected override void Use()
    // {
    //     base.Use();
    //     if (Player.instance.interactOnFocus == this && grabbed)
    //     {
    //     }
    // }
    //
    // public void SetGrabbed(bool isGrabbed)
    // {
    //     grabbed = isGrabbed;
    // }

    void Update()
    {
        // if (interactable.attachedToHand != null)
        // {
        //     SteamVR_Input_Sources source = interactable.attachedToHand.handType;
        //     if (fireAction[source].stateDown)
        //     {
        //         //isShooting = true;

        //     }
        //     else if (fireAction[source].stateUp)
        //     {

        //     }
        // } else
        // {
        //     waterEffect.Stop();
        // }
    }

    public void Shoot()
    {
        waterEffect.Play();
        audioSource.PlayOneShot(audioSource.clip);
    }

    public void StopShoot()
    {
        waterEffect.Stop();
    }

    // private void OnParticleCollision(GameObject other)
    // {
    //     Debug.Log("joo" + other.gameObject.name);
    // }
}