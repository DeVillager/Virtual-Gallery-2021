using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateArtistRooms : MonoBehaviour
{
    private String[] artists;
    public GameObject room;
    public float distance = 1f;
    public float height = 1;
    public float offAngle = 45;

    private Vector3 position;
    private float angle;

    void Start()
    {
        artists = GameManager.Instance.artists;
        angle = 360f / artists.Length;
        MakeInfos();
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    void Create(String roomName, int index)
    {
        float x = Mathf.Sin((index * angle + offAngle) * Mathf.Deg2Rad) * distance;
        float y = height;
        float z = Mathf.Cos((index * angle + offAngle) * Mathf.Deg2Rad) * distance;
        position = new Vector3(x, y, z);
        GameObject created = Instantiate(room, position, Quaternion.identity);
        created.GetComponent<LevelLoader>().defaulLevel = roomName;
        created.transform.rotation = Quaternion.Euler(new Vector3(0,angle * index + offAngle, 0));
        created.transform.SetParent(transform);
    }

    public void MakeInfos()
    {
        Debug.Log("Infos created");
        for (int i = 0; i < artists.Length; i++)
        {
            Create(artists[i], i);
        }
        // PlayBlobSound();
    }

    public void PlayBlobSound()
    {
        SoundPlayer.instance.Play("Blob");
    }
}