using System;
using BNG;
using UnityEditor.UIElements;
using UnityEngine;
using Random = UnityEngine.Random;

public class PaperBoat : MonoBehaviour
{
    private float _yrot;
    private float _time;
    private float _sailDirTime;
    private Grabbable _grabbable;
    public float rotationDir;

    public Rigidbody rb;
    public float sailTime = 4f;
    public int rotations = 4;
    public float rotationChance = 0.2f;

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

    private void OnCollisionEnter(Collision other)
    {
        transform.Rotate(0f, 180f, 0f);
    }

    private void Sail()
    {
        _sailDirTime += Time.deltaTime;
        if (_sailDirTime > sailTime)
        {
            sailTime = Random.Range(0f, 2f);
            rotationDir = Random.Range(0f, 1f) < rotationChance ? 1 : -1;
            _sailDirTime = 0;
        }
        
        if (_time < sailTime / rotations)
        {
            _time += Time.deltaTime;
            rb.velocity = transform.forward * speed;
        }
        else
        {
            // rotationDir = Random.Range(0f, 1f) < rotationChance ? 1 : -1;
            transform.Rotate(0f, 360f * rotationDir / rotations, 0f);
            _time = 0f;
        }
    }
}