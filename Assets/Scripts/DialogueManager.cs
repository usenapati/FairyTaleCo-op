using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class DialogueManager : MonoBehaviour
{
    private DialogueActions dialogueControls;

    private Queue<string> sentences;

    private static DialogueManager _instance;

    public Image characterImage;
    public TextMeshProUGUI dialogueText;

    public TextMeshProUGUI nameText;

    public Animator animator;

    private AudioSource audioPlayer;

    private UnityEvent dialogueEndedEvent;

    public DialogueTrigger dialogueTrigger;

    public static DialogueManager Instance
    {
        get
        {
            if(_instance == null)
            {
                GameObject instance = new GameObject("DialogueManager");
                instance.AddComponent<DialogueManager>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        _instance = this;
        dialogueControls = new DialogueActions();
    }

    private void OnEnable()
    {
        dialogueControls.Enable();
    }

    private void OnDisable()
    {
        dialogueControls.Disable();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        audioPlayer = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (dialogueControls.UI.AdvanceDialogue.triggered)
        {
            Debug.Log("KeyUp");
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        characterImage.sprite = dialogue.character.characterImage;

        audioPlayer.clip = dialogue.character.speakingSound;

        nameText.text = dialogue.character.characterName;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        dialogueTrigger.NextDialogue();
    }

    IEnumerator TypeSentence(string sentence)
    {
        
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            audioPlayer.Play();
            dialogueText.text += letter;
            
            yield return new WaitForSeconds(0.05f); //Wait a single frame
            audioPlayer.Stop();
        }   
    }
}
