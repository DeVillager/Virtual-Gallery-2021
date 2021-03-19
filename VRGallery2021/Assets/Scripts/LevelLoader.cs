using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : EventTrigger
{
    public String defaulLevel;

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
            SceneManager.LoadScene(level);
        }
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