using UnityEngine;
using System.Collections;
 
public class Underwater : MonoBehaviour {
 
    //This script enables underwater effects. Attach to main camera.
 
    //Define variable
    public float underwaterLevel = 0.89f;
    public Camera camera;
    public bool isUnderwater;
    public Color fogColor;
    public Color cameraBGColor = new Color(0, 0.4f, 0.7f, 1);
    public float fogDensity = 0.04f;
 
    //The scene's default fog settings
    private bool defaultFog;
    private Color defaultFogColor;
    private float defaultFogDensity;
    private Material defaultSkybox;
    private Material noSkybox;
 
    void Start () {
        defaultFog = RenderSettings.fog;
        defaultFogColor = RenderSettings.fogColor;
        defaultFogDensity = RenderSettings.fogDensity;
        defaultSkybox = RenderSettings.skybox;
        camera.backgroundColor = cameraBGColor;
        // isUnderwater = transform.position.y < underwaterLevel;
    }
 
    void Update () {
        if (transform.position.y < underwaterLevel && !isUnderwater)
        {
            ChangeToUnderwater();
        }
        else if (transform.position.y > underwaterLevel && isUnderwater)
        {
            ChangeToOverWater();
        }
    }

    private void ChangeToUnderwater()
    {
        Debug.Log("Underwater");
        RenderSettings.fog = true;
        // RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
        RenderSettings.fogColor = fogColor;
        RenderSettings.fogDensity = fogDensity;
        RenderSettings.skybox = noSkybox;
        isUnderwater = true;
    }
    
    private void ChangeToOverWater()
    {
        Debug.Log("Overwater");
        RenderSettings.fog = defaultFog;
        RenderSettings.fogColor = defaultFogColor;
        RenderSettings.fogDensity = defaultFogDensity;
        RenderSettings.skybox = defaultSkybox;
        isUnderwater = false;
    }
}