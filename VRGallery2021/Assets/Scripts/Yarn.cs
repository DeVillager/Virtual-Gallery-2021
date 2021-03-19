using UnityEngine;

public class Yarn : MonoBehaviour
{
    // Populate this array in the order you want the line to travel.
    public Transform[] transforms;   
    private LineRenderer _lineRenderer;
    public float ropeWidth = 0.03f;
    
    void Awake () {
        _lineRenderer = GetComponent<LineRenderer>();
        _lineRenderer.startWidth = ropeWidth;
        _lineRenderer.endWidth = ropeWidth;
        // Use this line again later, if transforms.Length changes. 
        // lineRenderer.SetVertexCount(transforms.Length);
        _lineRenderer.positionCount = transforms.Length;
    }
    
    void Update () {
        for(var i = 0; i < transforms.Length; ++i) 
            _lineRenderer.SetPosition(i, transforms[i].position);
    }
}
