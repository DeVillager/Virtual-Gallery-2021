using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource soundSource;
    public static SoundPlayer instance;
    public List<AudioClip> clips;
    
    private void Awake()
    {
        instance = this;
    }

    public void Play(string audioName)
    {
        foreach (var audioClip in clips.Where(audioClip => audioClip.name == audioName))
        {
            soundSource.PlayOneShot(audioClip);
            return;
        }
    }
}
