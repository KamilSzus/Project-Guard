using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    private void Start()
    {
        StartCoroutine(DelayedStartDialogue());
    }

    public void TriggerDialogue()
    {
        if (Pause.isPaused == false)
        {
            FindObjectOfType<DialogMenager>().StartDialogue(dialogue);
        }
    }

    public void TriggerOffDialogue()
    {
        if (Pause.isPaused == false)
        {
            FindObjectOfType<DialogMenager>().EndDialogue();
        }
    }

    IEnumerator DelayedStartDialogue()
    {
        yield return new WaitForSeconds(1);
        FindObjectOfType<DialogMenager>().StartDialogue(dialogue);
    }
}
