using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    public void ToggleLights()
    {
        foreach (Light light in transform.GetComponentsInChildren<Light>())
        {
            light.enabled = !light.enabled;
        }
    }
}
