using System;
using UnityEngine;
using BNG;

namespace VRGallery
{
    public class FloatingObject : MonoBehaviour
    {
        public Rigidbody rb;
        public float depthBeforeSubmerged = 1f;
        public float displacementAmount = 3f;
        public float waterHeight = 0.75f;
        private Grabbable _grabbable;

        private void Awake()
        {
            _grabbable = GetComponent<Grabbable>();
        }

        private void FixedUpdate()
        {
            if (!_grabbable.BeingHeld)
            {
                Float();
            }
        }

        private void Float()
        {
            if (transform.position.y < waterHeight)
            {
                float displacementMultiplier =
                    Mathf.Clamp01(-(transform.position.y - waterHeight) / depthBeforeSubmerged) *
                    displacementAmount;
                rb.AddForce(new Vector3(0f, Mathf.Abs(Physics.gravity.y) * displacementMultiplier, 0f),
                    ForceMode.Acceleration);
            }
        }
    }
}