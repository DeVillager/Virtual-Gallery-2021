using System;
using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : EventTrigger
{
    public String defaulLevel;
    private float delayTime = 0.1f;


    public void LoadLevel()
    {
        LoadLevel(defaulLevel);
    }

    public void LoadLevel(string level)
    {
        if (level == "Exit")
        {
            Debug.Log("Quitting gallery");
            Application.Quit();
        }
        else if (level == "MainRoom")
        {
            Debug.Log("Loading level " + level);
            FindObjectOfType<ScreenFader>()?.DoFadeIn();
            // StartCoroutine(LoadDelayed(level, delayTime));
            StartCoroutine(LoadYourAsyncScene("ClearMemory"));
        }
        else
        {
            Debug.Log("Loading level " + level);
            FindObjectOfType<ScreenFader>()?.DoFadeIn();
            // StartCoroutine(LoadDelayed(level, delayTime));
            StartCoroutine(LoadYourAsyncScene(level));
        }
    }

    public IEnumerator LoadYourAsyncScene(string level)
    {
        Resources.UnloadUnusedAssets();
        DestroyEverything();
        System.GC.Collect();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(level);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            // yield return new WaitForSecondsRealtime(0.05f);
            yield return null;
        }
    }

    public IEnumerator LoadDelayed(string level, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        int currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        int lastSceneIndex = SceneManager.sceneCountInBuildSettings - 1;
        Debug.Log(currentLevelIndex + ":" + lastSceneIndex);
        if (currentLevelIndex < lastSceneIndex)
        {
            Debug.Log("Loading next level");
            SceneManager.LoadScene(currentLevelIndex + 1);
        }
        else
        {
            Debug.Log("Final level reached");
        }
    }

    public void DestroyEverything()
    {
        List<GameObject> rootObjects = new List<GameObject>();
        Scene scene = SceneManager.GetActiveScene();
        scene.GetRootGameObjects(rootObjects);
        foreach (GameObject go in rootObjects)
        {
            if (!go.CompareTag("Exit"))
            {
                Destroy(go);
            }
        }
    }
}