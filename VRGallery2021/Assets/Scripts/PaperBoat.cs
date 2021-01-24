using System;
using BNG;
using UnityEngine;

public class PaperBoat : MonoBehaviour
{
    private float _yrot;
    private float _time;
    private Grabbable _grabbable;

    public Rigidbody rb;
    public float sailTime = 4f;
    public int rotations = 4;

    [SerializeField] private float speed = 1f;

    private void Awake()
    {
        _grabbable = GetComponent<Grabbable>();
    }

    void Update()
    {
        if (!_grabbable.BeingHeld)
        {
            Sail();
        }
    }

    private void Sail()
    {
        if (_time < sailTime / rotations)
        {
            _time += Time.deltaTime;
            rb.velocity = transform.forward * speed;
        }
        else
        {
            transform.Rotate(0f, 360f / rotations, 0f);
            _time = 0f;
        }
    }
}