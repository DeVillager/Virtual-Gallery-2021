using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;
    public bool forwardReversed = false;
    private Transform target;
    // public Vector2 rotationOffset;

    void Start()
    {
        target = Player.instance.transform.GetChild(0).transform;
    }

    void Update()
    {
        transform.LookAt(target);
        float yRotation = forwardReversed ? 0 : 180;
        float xRotation = forwardReversed ? -transform.eulerAngles.x : 0;
        transform.Rotate(xRotation, yRotation, 0);

        // if (forwardReversed)
        // {
        //     var rotation = transform.rotation;
        //     rotation = Quaternion.Euler(rotation.x, rotation.y, rotation.z);
        //     transform.rotation = rotation;
        // }
    }
}
