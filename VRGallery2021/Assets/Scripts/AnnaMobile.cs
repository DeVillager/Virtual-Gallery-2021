using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnnaMobile : MonoBehaviour
{
    public Material[] annagramImages;
    public Renderer screenRend;
    public int imgIndex = 0;
    

    
    void Start()
    {
    }

    private void ChangeImage(int index)
    {
        imgIndex = index % annagramImages.Length;
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
