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

    private void FixedUpdate()
    {
        _videoPlayer.playbackSpeed = Mathf.Clamp(videoSpeed / DistanceToPlayer(), 0.25f, 4f);
        // _audioSource.volume = 1 / DistanceToPlayer() * volumeScale;
    }

    private float DistanceToPlayer()
    {
        if (_playerTransform != null)
        {
            return Vector3.Distance(transform.position, _playerTransform.position);
        }
        return 1;
    }
}