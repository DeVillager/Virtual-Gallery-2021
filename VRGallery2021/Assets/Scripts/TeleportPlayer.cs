using System;
using System.Collections;
using UnityEngine;

public class TeleportPlayer : EventTrigger
{
    public Transform destination;
    public GameObject player;

    // private void Start()
    // {
    //     player = Player.instance.gameObject;
    // }

    public void TeleportToDestination()
    {
        StartCoroutine(Teleport());
    }

    private IEnumerator Teleport()
    {
        ShadeOut();
        yield return new WaitForSeconds(1);
        player.transform.position = destination.position;
    }

    private void ShadeOut()
    {
        throw new NotImplementedException();
    }
}