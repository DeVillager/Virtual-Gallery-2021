using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEngine;

public class AnnaPhoto : Interact
{
    private bool _triggered = false;

    protected override void Update()
    {
        if ((InputBridge.Instance.RightGripDown ||
             InputBridge.Instance.LeftGripDown ||
             InputBridge.Instance.RightTriggerDown ||
             InputBridge.Instance.LeftTriggerDown)
            && Player.instance.interactOnFocus == this)
        {
            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            Use();
        }
    }

    protected override void Use()
    {
        base.Use();
        if (_triggered) return;
        RevealText.instance.RevealMore();
        _triggered = true;
    }
}