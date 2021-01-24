/* SceneHandler.cs*/

using UnityEngine;
using System;
using DigitalRuby.SoundManagerNamespace;

public class ImageRotater : Interact
{
    public GameObject title;
    // public GameObject Description;
    private AudioSource _click;
    public bool activated;

    void Start()
    {
        _click = GetComponent<AudioSource>();
    }

    private void OnActivate()
    {
        gameObject.transform.Rotate(new Vector3(0, -90, 0), Space.World);
        title.SetActive(false);
        //Description.SetActive(true);
        _click.Play();
    }

    private void OnDeactivate()
    {
        gameObject.transform.Rotate(new Vector3(0, 90, 0), Space.World);
        title.SetActive(true);
        //Description.SetActive(false);
    }

    // protected override void Use()
    // {
    //     base.Use();
    //     if (activated)
    //     {
    //         OnActivate();
    //     }
    //     else
    //     {
    //         OnDeactivate();
    //     }
    //
    //     activated = !activated;
    // }
    
    protected override void OnTriggerEnter(Collider other)
    {
        Player.instance.interactOnFocus = this;
        focused = true;
        OnActivate();
    }

    protected override void OnTriggerExit(Collider other)
    {
        if (Player.instance.interactOnFocus == this)
        {
            Player.instance.interactOnFocus = null;
        }
        OnDeactivate();
        focused = false;
    }
}