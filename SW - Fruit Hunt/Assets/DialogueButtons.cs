using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    public GameObject[] dialogues;
    public GameObject dialogueParent;
    public int trackDialogue;

    public void AdvanceDialogue()
    {
        if(trackDialogue == dialogues.Length-1)
        {
            CloseDialogue();
        }
        else
        {
            dialogues[trackDialogue].SetActive(false);
            if (trackDialogue + 1 <= dialogues.Length)
                dialogues[trackDialogue + 1].SetActive(true);
            trackDialogue++;
        }

    }

    public void CloseDialogue()
    {
        dialogues[trackDialogue].SetActive(false);
        trackDialogue = 0;
        dialogues[trackDialogue].SetActive(true);
        dialogueParent.SetActive(false);

    }
}
