using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    private Animator _anim;
    public GameObject canvas;
    public bool sceneChangeEnabled = true;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        canvas.SetActive(true);
        _anim = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        StartCoroutine(DisableSceneChangeFOrSeconds(3f));
        // ShadeInScreen();
    }

    private IEnumerator DisableSceneChangeFOrSeconds(float t)
    {
        sceneChangeEnabled = false;
        yield return new WaitForSeconds(t);
        sceneChangeEnabled = true;
    }

    public void ShadeOutScreen()
    {
        Debug.Log("Shade out");
        _anim.SetTrigger("ShadeOut");
    }

    public void ShadeInScreen()
    {
        canvas.SetActive(true);
        Debug.Log("Shade in");
        _anim.SetTrigger("ShadeIn");
    }
}