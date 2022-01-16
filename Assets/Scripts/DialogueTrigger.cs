using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        if (Pause.isPaused == false)
        {
            FindObjectOfType<DialogMenager>().StartDialogue(dialogue);
        }
    }
}
