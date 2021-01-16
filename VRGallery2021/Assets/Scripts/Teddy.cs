using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teddy : MonoBehaviour
{
    public AudioSource kalinka;
    public AudioSource teddyPick;
    public AudioSource teddyDrop;

    public void PlayDropSound()
    {
        teddyDrop.PlayOneShot(teddyDrop.clip);
    }

    public void PlayPickSound()
    {
        teddyPick.PlayOneShot(teddyPick.clip);
    }

    public void SetKalinkaVolume(float vol)
    {
        kalinka.volume = vol;
    }

    // private void OnAttachedToHand(Hand hand)
    // {
    //     kalinka.volume = 1f;
    // }
    //
    // private void OnDetachedFromHand(Hand hand)
    // {
    //     kalinka.volume = 0.5f;
    // }
}