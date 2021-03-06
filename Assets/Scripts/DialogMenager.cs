using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogMenager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Animator animator;

    private Queue<string> sentences;

    void Start()
    {

        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (Pause.isPaused == false)
        {
            if (sentences.Count == 0)
            {
                EndDialogue();
                return;
            }

            string sentence = sentences.Dequeue();
            dialogueText.text = sentence;
        }
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        Debug.Log("END");
    }
}
