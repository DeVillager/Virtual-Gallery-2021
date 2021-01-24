using UnityEngine;

public class MaskGuy : MonoBehaviour
{
    [SerializeField]
    private float moveAmount = 0.05f;
    private GameObject _player;

    private void Start()
    {
        _player = Player.instance.transform.GetChild(0).gameObject;
    }

    public void MoveTowardPlayer()
    {
        transform.parent.position += transform.forward * moveAmount;
    }
}
