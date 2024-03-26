using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DialogueTrigger : MonoBehaviour
{
    public Dialoguee dialogue;

    public void TriggerDialogue()
    {
        Console.WriteLine("Пока мир...");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
