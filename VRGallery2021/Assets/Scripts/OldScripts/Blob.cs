using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : Interact
{
    public bool grabbed = false;
    // [SerializeField] private AudioSource audioSource;
    private Duplicate _duplicate;

    private void Awake()
    {
        _duplicate = GetComponent<Duplicate>();
    }

    protected override void Use()
    {
        base.Use();
        if (Player.instance.interactOnFocus == this && grabbed)
        {
            _duplicate.MakeDuplicates();
        }
    }

    public void SetGrabbed(bool isGrabbed)
    {
        grabbed = isGrabbed;
    }


}
