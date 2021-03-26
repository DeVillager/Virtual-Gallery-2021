using System.Collections;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoDelayed : MonoBehaviour
{
    public VideoPlayer vPlayer;
    public float delayTime = 3.0f;
    private void Awake()
    {
        vPlayer = GetComponent<VideoPlayer>();
    }

    void Start()
    {
        StartCoroutine(PlayDelayed());
    }

    private IEnumerator PlayDelayed()
    {
        yield return new WaitForSeconds(delayTime);
        vPlayer.Play();
    }
}
