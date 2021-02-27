using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileSwipe : MonoBehaviour
{
    public AnnaMobile mobile;
    public swipeDirection swipeDir;
    public enum swipeDirection
    {
        Left,
        Right
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Thumb"))
        {
            if (swipeDir == swipeDirection.Left)
            {
                mobile.PreviousImage();
            }
            else
            {
                mobile.NextImage();
            }
        }
    }
}
