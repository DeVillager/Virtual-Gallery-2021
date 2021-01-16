using BNG;
using UnityEngine;

public enum HandType
{
    Right,
    Left,
}

public class StickerPlacer : MonoBehaviour
{
    public Transform hand;

    public HandType handtype;
    public GameObject sticker;
    public LayerMask layerMask;
    public float distance = 1f;
    public float hitDistanceUp = 0.00001f;
    public float hitDistanceUpAmount = 0.00001f;
    public RaycastHit hit;
    private bool wasHit;
    private GameObject newSticker;
    private bool leftHandTriggered;
    private bool rightHandTriggered;

    void Update()
    {
        wasHit = Physics.Raycast(hand.position, hand.forward, out hit, distance, layerMask);
        // if (wasHit) Debug.Log("was hit: " + hit.collider.gameObject.name);
        leftHandTriggered = handtype == HandType.Left && InputBridge.Instance.LeftTriggerDown;
        rightHandTriggered = handtype == HandType.Right && InputBridge.Instance.RightTriggerDown;

        if ((leftHandTriggered || rightHandTriggered) && wasHit)
        {
            Debug.Log("Sticker placed");
            SoundPlayer.instance.Play("sticker");
            PlaceSticker();
        }

    }

    private void PlaceSticker()
    {
        hitDistanceUp += hitDistanceUpAmount;
        newSticker = Instantiate(sticker, hit.point + hit.normal * hitDistanceUp, transform.rotation);

        newSticker.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
        newSticker.transform.Rotate(new Vector3(90 + UnityEngine.Random.Range(0, 360f), 90, 0));

        newSticker.transform.parent = hit.transform;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = wasHit ? Color.red : Color.green;
        var position = hand.position;
        Gizmos.DrawLine(position, position + hand.forward * distance);
    }
}