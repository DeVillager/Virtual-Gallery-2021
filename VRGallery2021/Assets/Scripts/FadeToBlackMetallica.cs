using UnityEngine;
using UnityEngine.UI;

public class FadeToBlackMetallica : MonoBehaviour
{
    public float depth = -10f;
    public Transform player;
    public Image overlayImage;
    public float opacitySpeed = 1f;
    // public Color overlayImageColor;

    void Start()
    {
    }

    void Update()
    {
        float distance = DistanceToDepth();
        ChangeScreenOpacity(distance);
    }

    private void ChangeScreenOpacity(float distance)
    {
        // overlayImageColor = overlayImage.color;
        var imageColor = overlayImage.color;
        imageColor.r = Mathf.Clamp(opacitySpeed / distance, 0, 255);
        // overlayImageColor.r  = Mathf.Clamp(opacitySpeed / distance, 0, 255);
    }

    private float DistanceToDepth()
    {
        return player.position.y - depth;
    }
}