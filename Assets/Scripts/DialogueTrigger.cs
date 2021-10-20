using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            //src: https://answers.unity.com/questions/1141235/how-to-move-to-next-scene-using-scene-manager.html
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } 
        else {
            Dialogue d = dialogues[0];
            dialogues.Remove(d);
            DialogueManager.Instance.StartDialogue(d);
        }
        
    }
}
