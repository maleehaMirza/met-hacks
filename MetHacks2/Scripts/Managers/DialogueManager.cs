using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public Dialogue autodialogue;
    public bool autostart = false;
    public bool switchend = false;

    public Animator animator;

    //keep track of all sentences in dialogue
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();  
        if(autostart == true)
        {
            StartDialogue(autodialogue);
        }
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //in case user skips text, stops animation
        StopAllCoroutines();
        //animate the text by running type sentence co routine (function)
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text = "";
        //will convert string to character array
        foreach(char letter in sentence.ToCharArray())
        {
            //will append letter to end of string one by one
            dialogueText.text += letter;
            yield return null;
        }

    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
        
        if(switchend == true)
        {
            ScenesManager.Instance.LoadNextScene();
        }
        return;
    }

}
