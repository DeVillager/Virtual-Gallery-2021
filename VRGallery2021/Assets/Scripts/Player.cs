using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    public Interact interactOnFocus = null;
    
    void Awake()
    {
        // if (instance != this)
        // {
        //     Destroy(gameObject);
        // }
        instance = this;
    }

    
}
