using UnityEngine;

public class ClubLight : MonoBehaviour
{
    private float x;
    private float t;
    public float rotationSpeed;
    private float angleX;
    private float angleY;
    private float angleZ;
    public float maxRotation;

    void Start()
    {
        // var localRotation = transform.localRotation;
        // angleX = localRotation.x;
        // angleY = localRotation.y;
        // angleZ = localRotation.z;
    }    

    void FixedUpdate()
    {
        t += Time.deltaTime * rotationSpeed;
        // x = angleX + Mathf.Sin(t) * maxRotation;
        // Quaternion q = transform.localRotation;
        transform.Rotate(Vector3.up,Mathf.Sin(t) * maxRotation);
        // transform.localRotation = Quaternion.Euler(x, q.y, q.z);
    }
}