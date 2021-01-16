using UnityEngine;

public class SceneChangeTouch : MonoBehaviour
{
    public GameObject[] destroyables;
    private bool handHover = false;

    void Start()
    {
        // sceneLoader = GetComponent<SteamVR_LoadLevel>();
        // interactable = GetComponent<Interactable>();
    }

    public void OnHandHoverBegin()
    {
        handHover = true;
        //hand.ShowGrabHint();
    }
    public void OnHandHoverEnd()
    {
        handHover = false;
        //hand.ShowGrabHint();
    }

    void Update()
    {
        // if (loadAction.stateDown && handHover)
        // {
        //     Debug.Log("Scene loaded");
        //     if (destroyables.Length > 0)
        //     {
        //         foreach (var item in destroyables)
        //         {
        //             Destroy(item);
        //         }
        //     }
        //     sceneLoader.Trigger();
        // }
    }
}
