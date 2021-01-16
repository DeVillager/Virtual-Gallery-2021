using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDelayed : MonoBehaviour
{
    public float lifeTime = 2f;
    private float _time;

    void Start()
    {
        _time = 0f;
    }
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
