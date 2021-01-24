using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEngine;

public class ExitTouch : SceneLoader
{
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

}
