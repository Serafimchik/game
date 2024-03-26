using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DialogueAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogueManager dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        Console.WriteLine("открыть");
        startAnim.SetBool("startOpen", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        Console.WriteLine("закрыть");
        startAnim.SetBool("startOpen", false);
        dm.EndDialogue();
    }
}
