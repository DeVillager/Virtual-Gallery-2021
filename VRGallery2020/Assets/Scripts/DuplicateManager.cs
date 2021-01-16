using UnityEngine;
using UnityEngine.SceneManagement;

public class DuplicateManager : MonoBehaviour
{

    public static DuplicateManager instance;
    public Transform container;
    public GameObject sphere;
    public int childLimit = 60;
    private GameObject _activeObject;

    private void Awake()
    {
        instance = this;
    }

    public void RemoveDuplicates()
    {
        foreach (Transform child in container)
        {
            Destroy(child.gameObject);
        }
        Debug.Log("Duplicates destroyed");
        GetComponent<AudioSource>().Play();
        sphere.transform.position = transform.position + Vector3.up * 0.2f;
        sphere.GetComponent<Rigidbody>().velocity = Vector3.zero;
        container.GetComponent<BlobInitializer>().MakeSceneBlobs();
    }

    public void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetActiveObject(GameObject go)
    {
        _activeObject = go;
    }

    public void RemoveBlobsOverLimit()
    {
        int blobsAmount = container.childCount;
        if (blobsAmount > childLimit)
        {
            int removeAmount = blobsAmount - childLimit;
            for (int i = 0; i < removeAmount; i++)
            {
                GameObject go = container.GetChild(i).gameObject;
                if (go != _activeObject)
                {
                    Destroy(go);
                }
            }
        }
    }
}
