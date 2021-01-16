using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RevealText : MonoBehaviour
{
    public Sprite[] sprites;
    private int index;
    private Image image;
    private AudioSource audioSource;
    public static RevealText instance;

    void Start()
    {
        instance = this;
        image = GetComponent<Image>();
        audioSource = GetComponent<AudioSource>();
        index = 0;
        RevealMore();
    }

    public void RevealMore()
    {
        Debug.Log("revealed more");
        SoundPlayer.instance.Play("waterDroplet2");
        audioSource.PlayOneShot(audioSource.clip);
        if (index < sprites.Length)
        {
            image.sprite = sprites[index];
            index++;
        }
    }
}
