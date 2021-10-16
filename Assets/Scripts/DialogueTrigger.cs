using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public List<Dialogue> dialogues;

    public void TriggerDialogue ()
    {
        NextDialogue();
    }

    public void NextDialogue()
    {
        if (dialogues.Count == 0)
        {
            //Call GameManager to move to next scene, or whatever
        } 
        else {
            Dialogue d = dialogues[0];
            dialogues.Remove(d);
            DialogueManager.Instance.StartDialogue(d);
        }
        
    }
}
