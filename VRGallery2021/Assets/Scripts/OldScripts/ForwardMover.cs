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

    private Vector3 _moveDirection;

    void Update()
    {
        _direction = forwardReversed ? -1 : 1;
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