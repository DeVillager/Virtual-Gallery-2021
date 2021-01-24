using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform start;
    private LineRenderer _lr;
    public bool useCustomTransform;
    public Vector3 offSet;
    

    void Start()
    {
        _lr = GetComponent<LineRenderer>();
        start = useCustomTransform ? start : transform;
        start.position += offSet;
    }

    // Update is called once per frame
    void Update()
    {
        _lr.SetPosition(0, start.position);
        RaycastHit hit;
        if (Physics.Raycast(start.position, start.forward, out hit))
        {
            if (hit.collider)
            {
                _lr.SetPosition(1, hit.point);
            }
        }
        else _lr.SetPosition(1, start.forward * 5000);
    }
}