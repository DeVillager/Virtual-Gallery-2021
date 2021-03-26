using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public GameObject myPlayer;
    public float waitTime = 4f;
    void Start()
    {
        StartCoroutine(LoadPlayer());
    }

    private IEnumerator LoadPlayer()
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(myPlayer, transform.position, Quaternion.identity);
    }
}
