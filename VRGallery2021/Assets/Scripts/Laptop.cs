using UnityEngine;
using UnityEngine.Video;

public class Laptop : MonoBehaviour
{
    private VideoPlayer _videoPlayer;
    // private AudioSource _audioSource;
    // public float defaultVideoSpeed = 1;
    // public float maxPlayBackSpeed = 4;
    public Transform _playerTransform;
    // public float volumeScale = 1;
    [SerializeField] private float videoSpeed = 1;

    protected void Awake()
    {
        // base.Awake();
        _videoPlayer = GetComponent<VideoPlayer>();
        // _audioSource = GetComponent<AudioSource>();
        PlayVideo();
    }

    public void PlayVideo()
    {
        _videoPlayer.Play();
    }    
    
    public void StopVideo()
    {
        _videoPlayer.Stop();
    }

    private void Update()
    {
        _videoPlayer.playbackSpeed = videoSpeed / DistanceToPlayer();
        // _audioSource.volume = 1 / DistanceToPlayer() * volumeScale;
    }

    private float DistanceToPlayer()
    {
        return Vector3.Distance(transform.position, _playerTransform.position);
    }
}
