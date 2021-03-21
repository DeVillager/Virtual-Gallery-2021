using System.Collections;
using UnityEngine;

public class PlayMusicDelayed : MonoBehaviour
{
    private AudioSource _audioSource;
    public float playDelayed = 2f;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        StartCoroutine(PlayDelayed());
    }

    private IEnumerator PlayDelayed()
    {
        yield return new WaitForSeconds(playDelayed);
        _audioSource.Play();
    }
}
