using BNG;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public bool focused = false;

    protected virtual void Update()
    {
        if ((InputBridge.Instance.RightTriggerDown || InputBridge.Instance.LeftTriggerDown) && Player.instance.interactOnFocus == this)
        {
            // ReSharper disable once Unity.PerformanceCriticalCodeInvocation
            Use();
        }
    }
    
    protected virtual void Use()
    {
        Debug.Log(gameObject.name + " used");
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.gameObject.tag);
        if (other.gameObject.CompareTag("Hand"))
        {
            Player.instance.interactOnFocus = this;
            SetFocus(true);
        }
    }

    protected virtual void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            if (Player.instance.interactOnFocus == this)
            {
                Player.instance.interactOnFocus = null;
            }
            SetFocus(false);
        }
    }

    protected virtual void SetFocus(bool onFocus)
    {
        focused = onFocus;
        Debug.Log(focused ? "focus on" : "lost focus");
    }

}