using System;
using BNG;
using UnityEngine;

public class RotateImages : MonoBehaviour
{
    public float speed = 10;
    public bool yRotationEnabled;
    
    private float _rotationX;
    private float _rotationY;
    private Vector3 _rot;

    void Update()
    {
        _rotationX = InputBridge.Instance.LeftThumbstickAxis.x;
        _rotationY = InputBridge.Instance.LeftThumbstickAxis.y;
        if (Mathf.Abs(_rotationX) > 0.1)
        {
            _rot.x = _rotationX;
            _rot.y = yRotationEnabled ? _rotationY : 0;
            gameObject.transform.Rotate(_rot * (speed * Time.deltaTime), Space.World);
        }
    }
}