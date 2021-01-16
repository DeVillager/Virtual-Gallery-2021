using System;
using OculusSampleFramework;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ArtistImage : SceneLoader
{
    public GameObject artistInfo;
    public bool loadName = true;
    // public string sceneName;

    private void Start()
    {
        // artistInfo = transform.GetChild(0).gameObject;
        if (loadName) loadScene = gameObject.name;
        HideInfo();
    }

    protected override void OnTriggerEnter(Collider other)
    {
        Player.instance.interactOnFocus = this;
        focused = true;
        ShowInfo();
    }

    protected override void OnTriggerExit(Collider other)
    {
        if (Player.instance.interactOnFocus == this)
        {
            Player.instance.interactOnFocus = null;
        }
        focused = false;
        HideInfo();
    }
    

    // protected override void SetFocus(bool onFocus)
    // {
    //     base.SetFocus(onFocus);
    //     if (focused)
    //     {
    //         ShowInfo();
    //     }
    //     else
    //     {
    //         HideInfo();
    //     }
    // }

    public void ShowInfo()
    {
        artistInfo.SetActive(true);
    }

    public void HideInfo()
    {
        artistInfo.SetActive(false);
    }
}