using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnaMobile : MonoBehaviour
{
    public Material[] annagramImages;
    public Renderer screenRend;
    public int imgIndex;

    void Start()
    {
        imgIndex = 0;
    }

    private void ChangeImage(int index)
    {
        Debug.Log("annaimages length " + annagramImages.Length + "imgindex " + imgIndex);
        imgIndex = (imgIndex + annagramImages.Length) % annagramImages.Length;
        Debug.Log("Changed img to " + annagramImages[imgIndex].name);
        screenRend.material = annagramImages[imgIndex];
    }

    public void NextImage()
    {
        ChangeImage(imgIndex++);
    }

    public void PreviousImage()
    {
        ChangeImage(imgIndex--);
    }

}
