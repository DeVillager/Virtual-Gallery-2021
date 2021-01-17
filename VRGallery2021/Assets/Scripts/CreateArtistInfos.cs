using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class CreateArtistInfos : MonoBehaviour
{
    private String[] artists;
    public GameObject artistInfo;
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

    public void MakeInfos()
    {
        Debug.Log("Infos created");
        for (int i = 0; i < artists.Length; i++)
        {
            Create(artists[i], i);
        }
        // PlayBlobSound();
    }

    void Create(String artistName, int index)
    {
        float x = Mathf.Sin((index * angle + offAngle) * Mathf.Deg2Rad) * distance;
        float y = height;
        float z = Mathf.Cos((index * angle + offAngle) * Mathf.Deg2Rad) * distance;
        position = new Vector3(x, y, z);
        GameObject created = Instantiate(artistInfo, position, Quaternion.identity);
        created.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = artistName;
        created.transform.rotation = Quaternion.Euler(new Vector3(0,angle * index + offAngle, 0));
        created.transform.SetParent(transform);
        // created.transform.localScale = Vector3.one * Random.Range(5, 10);
        // created.GetComponent<Duplicate>().original = false;
    }

    public void PlayBlobSound()
    {
        SoundPlayer.instance.Play("Blob");
    }
}