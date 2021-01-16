using UnityEngine;
using DigitalRuby.SoundManagerNamespace;

public class Duplicate : MonoBehaviour
{
    public GameObject duplicate;
    // public SteamVR_Action_Boolean duplicateAction;
    // private Interactable interactable;
    public float distance = 1f;
    public Transform parent;
    // public AudioSource blob;
    public bool original = false;

    private float phi = 1.618f;
    private Vector3 position;

    void Start()
    {
        // interactable = GetComponent<Interactable>();
        if (gameObject.tag == "Gallery")
        {
            MakeDuplicates();
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if (!original && transform.parent != parent)
        {
            transform.SetParent(parent);
        }
    }

    public void MakeDuplicates()
    {
        Create(0, 1, phi);
        Create(0, -1, phi);
        Create(0, 1, -phi);
        Create(0, -1, -phi);
        Create(1, phi, 0);
        Create(-1, phi, 0);
        Create(1, -phi, 0);
        Create(-1, -phi, 0);
        Create(phi, 0, 1);
        Create(phi, 0, -1);
        Create(-phi, 0, 1);
        Create(-phi, 0, -1);
        Debug.Log("Duplicates created");
        PlayBlobSound();
        DuplicateManager.instance.RemoveBlobsOverLimit();
        // GetComponent<Collider>().enabled = false;
        Destroy(gameObject);
    }

    void Create(float x, float y, float z)
    {
        position = transform.position + new Vector3(x, y, z) * distance;
        GameObject created = Instantiate(duplicate, position, Quaternion.identity);
        created.transform.SetParent(parent);
        created.GetComponent<Rigidbody>().isKinematic = false;
        created.transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        created.transform.localScale = Vector3.one * Random.Range(5, 10);
        created.GetComponent<Duplicate>().original = false;
    }
    
    public void PlayBlobSound()
    {
        SoundPlayer.instance.Play("Blob");
    }

}
