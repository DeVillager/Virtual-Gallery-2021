using System;
using System.Collections;
using BNG;
using UnityEngine;

public class TeleportPlayer : EventTrigger
{
    public Transform destination;
    public PlayerTeleport playerTeleport;
    
    public void TeleportToDestination()
    {
        StartCoroutine(Teleport());
    }

    private IEnumerator Teleport()
    {
        // ShadeOut();
        yield return new WaitForSeconds(0);
        playerTeleport.TeleportPlayer(destination.position, Quaternion.identity);
        Debug.Log("TELEPORTTING PLAYER");
    }

    private void ShadeOut()
    {
        throw new NotImplementedException();
    }
}