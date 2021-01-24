using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectObject : MonoBehaviour
{
    public List<GameObject> connectedObjects;
    public Dictionary<GameObject, Vector3> objectPositions;
    public Dictionary<GameObject, Quaternion> objectRotations;
    public float radius = 1f;
    public LayerMask layerMask;

    void Start()
    {
        objectPositions = new Dictionary<GameObject, Vector3>();
        objectRotations = new Dictionary<GameObject, Quaternion>();
        AddNeighbors();
        foreach (GameObject obj in connectedObjects)
        {
            objectPositions[obj] = obj.transform.position;
            objectRotations[obj] = obj.transform.rotation;
        }
    }

    private void AddNeighbors()
    {
        Collider[] neighbors = Physics.OverlapSphere(transform.position, radius, layerMask);
        foreach (Collider item in neighbors)
        {
            connectedObjects.Add(item.gameObject);
        }
    }
}
