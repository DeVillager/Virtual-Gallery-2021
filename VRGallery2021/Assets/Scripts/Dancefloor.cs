using System;
using BNG;
using UnityEngine;

public class Dancefloor : MonoBehaviour
{
    private float _time;
    private Material[] _materials;
    private int i;
    
    [SerializeField] private float colorTime = 0.5f;
    [SerializeField] private Color[] colors;

    private void Awake()
    {
        _materials = GetComponent<MeshRenderer>().materials;
    }

    void Update()
    {
        if (_time < colorTime)
        {
            _time += Time.deltaTime;
        }
        else
        {
            i++;
            i = i % colors.Length;
            ChangeColor(i);
            _time = 0f;
        }
    }

    private void ChangeColor(int i)
    {
        _materials[0].color = colors[i];
    }
}