using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class DialogueTrigger : MonoBehaviour
{
    public Dialoguee dialogue;

    public void TriggerDialogue()
    {
        Console.WriteLine("���� ���...");
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
