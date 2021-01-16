using System.Collections;
using BNG;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class SceneLoader : Interact
{
    public string loadScene;
    public float loadDelay;

    protected override void Use()
    {
        base.Use();
        if (Player.instance.interactOnFocus == this && UIManager.instance.sceneChangeEnabled)
        {
            SoundPlayer.instance.Play("warp");
            // UIManager.instance.ShadeOutScreen();
            // SceneManager.LoadScene(loadScene);
            StartCoroutine(LoadSceneDelayed());
        }
    }

    private IEnumerator LoadSceneDelayed()
    {
        // ScreenFader.Instance.DoFadeIn();
        // UIManager.instance.ShadeOutScreen();
        yield return  new WaitForSeconds(loadDelay);
        // yield return  new WaitForSeconds(0);
        // SceneManager.LoadScene(loadScene);
        SceneManager.LoadSceneAsync(loadScene);
    }
}
