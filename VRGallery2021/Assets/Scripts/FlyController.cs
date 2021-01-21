using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace BNG {
    /// <summary>
    /// Like a jetpack, but for your hands.
    /// </summary>
    public class FlyController : MonoBehaviour {

        public float JetForce = 10f;
        CharacterController characterController;
        public InputBridge input;
        public Transform _handTransform;
        
        private void Awake() {
            input = InputBridge.Instance;
        }

        void Start() {
            GameObject player = GameObject.FindGameObjectWithTag("Player");

            if(player) {
                characterController = player.GetComponentInChildren<CharacterController>();
            }
            else {
                Debug.Log("No player object found.");
            }
        }

        public void Update() {
            if(input.RightTrigger > 0.25f) {
                doJet(input.RightTrigger);
            }
            else {
                stopJet();
            }
        }


        void doJet(float triggerValue) {
            Vector3 moveDirection = _handTransform.forward * JetForce;
            characterController.Move(moveDirection * (Time.deltaTime * triggerValue));
            // Sound
            // if (!audioSource.isPlaying) {
            //     audioSource.pitch = Time.timeScale;
            //     audioSource.Play();
            // }

            // Particle FX
            // if(JetFX != null && !JetFX.isPlaying) {
            //     JetFX.Play();
            // }
        }

        void stopJet() {

            // if (audioSource.isPlaying) {
            //     audioSource.Stop();
            // }
            //
            // if (JetFX != null && JetFX.isPlaying) {
            //     JetFX.Stop();
            // }
        }
        
    }
}

