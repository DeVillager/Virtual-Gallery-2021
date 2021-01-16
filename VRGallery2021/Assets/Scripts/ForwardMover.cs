using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.SoundManagerNamespace;


public class ForwardMover : MonoBehaviour
{
    [SerializeField] private int speed = 3;
    public bool forwardReversed = true;
    public bool axisReversed;
    private int _direction;
    // public GameObject movable;
    // public Transform goTransform;
    private Vector3 _moveDirection;

    void Update()
    {
        _direction = forwardReversed ? -1 : 1;
        // _moveDirection = axisReversed ? transform.right : transform.forward;
        // transform.Translate(_moveDirection * (_direction * Time.deltaTime * speed));
        
        // transform.position += _moveDirection * (_direction * Time.deltaTime * speed);
        if (axisReversed)
        {
            transform.position += transform.right * (_direction * Time.deltaTime * speed);
        }
        else
        {
            transform.position += transform.forward * (_direction * Time.deltaTime * speed);
        }
    }
}