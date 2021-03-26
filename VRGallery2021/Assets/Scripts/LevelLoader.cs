using System;
using System.Collections;
using System.Collections.Generic;
using BNG;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class LevelLoader : EventTrigger
{
    public String defaulLevel;
    private float delayTime = 0.2f;
    private bool loading = false;
    private DisableMovement movementDisabler;
    private GameObject myPlayer;

    private void Start()
    {
        movementDisabler = FindObjectOfType<DisableMovement>();
        myPlayer = movementDisabler.gameObject;
        Resources.UnloadUnusedAssets();
    }

    public void LoadLevel()
    {
        LoadLevel(defaulLevel);
    }

    public void LoadLevel(string level)
    {
        if (!loading)
        {
            loading = true;
            if (level == "Exit")
            {
                Application.Quit();
            }
            else
            {
                FindObjectOfType<ScreenFader>()?.DoFadeIn();
                StopAllAnimations();
                StopAllVideos();
                // DestroyEverything();
                movementDisabler.DisablePlayerController();
                
                GC.Collect();
                StartCoroutine(LoadDelayed(level, delayTime));
            }
        }
    }

    public IEnumerator LoadYourAsyncScene(string level)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(level);
        while (!asyncLoad.isDone)
        {
            // yield return new WaitForSecondsRealtime(0.05f);
            yield return null;
        }
    }

    public IEnumerator LoadDelayed(string level, float delay)
    {
        yield return new WaitForSeconds(delay);
        DestroyPlayer();
        SceneManager.LoadScene(level);
    }

    public void StopAllAnimations()
    {
        Animator[] animators = GetComponents<Animator>();
        foreach (Animator animator in animators)
        {
            animator.enabled = false;
        }
    }


    public void StopAllVideos()
    {
        VideoPlayer[] videos = GetComponents<VideoPlayer>();
        foreach (VideoPlayer video in videos)
        {
            video.Stop();
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
    
    public void DestroyPlayer()
    {
        Destroy(myPlayer);
    }
}