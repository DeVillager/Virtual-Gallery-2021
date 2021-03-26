using System.Collections;
using BNG;
using UnityEngine;

public class DisableMovement : MonoBehaviour
{
    public float delay = 1.0f;
    
    void Start()
    {
        // DisablePlayerController();
        StartCoroutine(EnablePlayerController());
    }

    public void DisablePlayerController()
    {
        GetComponent<InputBridge>().enabled = false;
    }
    
    public IEnumerator EnablePlayerController()
    {
        yield return new WaitForSeconds(delay);
        GetComponent<InputBridge>().enabled = true;
    }
}


