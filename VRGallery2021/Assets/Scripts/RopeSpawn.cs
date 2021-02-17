using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotateAxis;
    public float speed = 1f;

    void Update()
    {
        transform.Rotate(rotateAxis, speed);
    }
}