using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : SceneLoader
{
    public bool quitExit = false;

    protected override void OnTriggerEnter(Collider other)
    {
        Player.instance.interactOnFocus = this;
        focused = true;
    }

    protected override void OnTriggerExit(Collider other)
    {
        if (Player.instance.interactOnFocus == this)
        {
            Player.instance.interactOnFocus = null;
        }
        focused = false;
    }

    protected override void Use()
    {
        if (quitExit)
        {
            Debug.Log("Quitting game...");
            Application.Quit();
        }
        else
        {
            base.Use();
        }
    }
}