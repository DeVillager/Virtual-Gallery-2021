using UnityEngine;

public class GalleryRotater : MonoBehaviour
{
    public GameObject[] planes;
    public float radius = 4;
    public float height = 1;

    void Awake()
    {
        int numberOfObjects = planes.Length;
        for (int i = 0; i < numberOfObjects; i++)
        {
            float angle = i * Mathf.PI * 2 / numberOfObjects;
            Debug.Log(angle * Mathf.Rad2Deg);
            Vector3 pos = new Vector3(Mathf.Cos(angle), height, Mathf.Sin(angle)) * radius;

            Instantiate(planes[i], pos, Quaternion.Euler(0, -angle * Mathf.Rad2Deg, 0), this.transform);
        }
    }
}