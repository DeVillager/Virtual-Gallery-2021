using System.Collections;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public Animator anim;
    public int paintingNumber;
    public ParticleSystem ps;
    public float delayTime = 2f;
    public GameObject videoscreen;
    public GameObject blueMan;
    public bool playOnAwake;
    private AudioSource audioSource;

    private void Start()
    {
        BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.size *= 1.05f;
        boxCollider.isTrigger = true;
        audioSource = GetComponent<AudioSource>();
        if (playOnAwake)
        {
            PlayPaintingAnimation();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if (other.CompareTag("Hand"))
        {
            audioSource.Play();
            PlayPaintingAnimation();
        }
    }

    private void PlayPaintingAnimation()
    {
        if (paintingNumber == 1)
        {
            StartCoroutine(Painting1());
        }
        else if (paintingNumber == 2)
        {
            anim.SetTrigger("Touch");
        }
        else if (paintingNumber == 3)
        {
            StartCoroutine(Painting3());
        }
        else if (paintingNumber == 4)
        {
            blueMan.SetActive(false);
            blueMan.SetActive(true);
        }
    }

    private IEnumerator Painting1()
    {
        ps.Play();
        yield return new WaitForSeconds(delayTime);
        ps.Stop();
        anim.SetTrigger("Touch");
    }
    
    private IEnumerator Painting3()
    {
        videoscreen.SetActive(true);
        yield return new WaitForSeconds(delayTime);
        anim.SetTrigger("Touch");
    }
}