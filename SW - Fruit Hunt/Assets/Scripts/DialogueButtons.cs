using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtons : MonoBehaviour
{
    public GameObject[] dialogues;
    public GameObject dialogueParent;
    public int trackDialogue;
    public bool cnm;
    public bool helga;
    public bool kid;

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
        UpdateRob();
        dialogues[trackDialogue].SetActive(false);
        trackDialogue = 0;
        dialogues[trackDialogue].SetActive(true);
        dialogueParent.SetActive(false);

    }

    public void UpdateRob()
    {
        TimersCountdown spawner = FindAnyObjectByType<TimersCountdown>();
        if(helga)
        {
            spawner.helgaTalked = true;
        }
        else if (kid)
        {
            spawner.kidTalked = true;
        }
        else if (cnm)
        {
            spawner.cnmTalked = true;
        }
        spawner.SpawnRob();
    }
}
