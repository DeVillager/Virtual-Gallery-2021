using System;
using System.Collections;
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
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.
        Resources.UnloadUnusedAssets();
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(level);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
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
}