﻿using UnityEngine;
using UnityEngine.Analytics;

namespace DialogueSystem
{
    public class DialogueTrigger : EventTrigger
    {
        // [Tooltip("If zero, reading manual")]
        // public float dialogTime; 
        public Dialogue dialogue;
        public bool oneTimeTrigger;
        private bool _triggered;

        public void DisplayDialogue()
        {
            if (oneTimeTrigger && _triggered) { return; }
            _triggered = true;
            Debug.Log("Starting dialogue");
            DialogueManager.Instance.StartDialogue(dialogue);
        }
    }
}