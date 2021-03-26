using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearMemory : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Collecting garbage...");
        Resources.UnloadUnusedAssets();
        System.GC.Collect();
        SceneManager.LoadScene("MainRoom");
    }
}
