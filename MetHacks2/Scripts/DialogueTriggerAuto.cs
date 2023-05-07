using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerAuto : MonoBehaviour
{
    public Dialogue dialogue;
    void Start()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

}
