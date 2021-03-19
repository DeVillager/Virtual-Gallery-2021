using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using Random = UnityEngine.Random;

public class Building : MonoBehaviour
{
    public GameObject[] screens;
    public int amount = 15;
    private bool[,] grid;
    public int scale = 10;
    public int height = 10;
    public int offSet = 0;
    public int offSet2 = 10;

    void Start()
    {
        grid = new bool[30, 30];
        int i = 0;
        while (i < amount)
        {
            int x = Random.Range(0, 4);
            int y = Random.Range(1, 5);
            int y2 = Random.Range(0, 2);
            y2 = y2 == 0 ? -1 : 1;
            if (!grid[x,y])
            {
                int index = Random.Range(0, screens.Length);
                GameObject go = screens[index];
                int x2 = 0, z2 = 0;
                switch (x)
                {
                    case 0:
                        x2 = -1;
                        break;
                    case 1:
                        z2 = 1;
                        break;
                    case 2:
                        x2 = 1;
                        break;
                    default:
                        z2 = -1;
                        break;
                }

                Vector3 offsetWidth = x2 == 0 ? Vector3.left : Vector3.forward;
                GameObject created = Instantiate(go, transform.position + new Vector3(x2 * scale, y * height * transform.localScale.y, z2 * scale) + offsetWidth * y2 * offSet2, Quaternion.identity);
                created.transform.rotation = Quaternion.Euler(new Vector3(0,x * 90 + offSet, 0));
                created.transform.SetParent(transform);
                grid[x,y] = true;
                i++;
            }
        }
    }
}