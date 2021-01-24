using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1;
    // Use this for initialization
    private Vector3 velocity;
    private Rigidbody rb;
    public LayerMask collisionMask;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        SetSpeed(1f);
    }

    public void SetSpeed(float shootingSpeed)
    {
        velocity = transform.forward * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
