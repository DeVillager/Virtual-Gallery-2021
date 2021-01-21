using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Random = UnityEngine.Random;

public class BuildingSpawner : MonoBehaviour
{
    public GameObject[] buildings;
    public int amount = 20;
    private bool[,] grid;
    public int size = 10;
    public int scale = 10;

    void Start()
    {
        grid = new bool[30, 30];
        int i = 0;
        while (i < amount)
        {
            int x = Random.Range(0, size);
            int z = Random.Range(0, size);
            int bIndex = Random.Range(0, buildings.Length);
            GameObject go = buildings[bIndex];
            if (!grid[x,z] && (x != 5 || z != 5) && (x != 7 || z != 5))
            {
                GameObject created = Instantiate(go, transform.position + new Vector3(x,0,z) * scale, Quaternion.identity);
                // created.transform.s = new Vector3(0, Random.Range(0.5f, 2f),0);
                created.transform.SetParent(transform);
                created.transform.localScale = new Vector3(1, Random.Range(0.5f, 2f),1);
                grid[x,z] = true;
                i++;
            }
        }
    }
}