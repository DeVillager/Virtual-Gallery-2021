using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public void PlayClick()
    {
        SoundPlayer.instance.Play("click");
    }
}
