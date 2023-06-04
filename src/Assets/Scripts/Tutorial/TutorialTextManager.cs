using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialTextManager : MonoBehaviour
{
    public PlayerMovement move;

    public TMP_Text TutorialSpace;
    public GameObject TutorialPanel;
    public Animator animator;

    private Queue<string> TutorialSentences;

    // Start is called before the first frame update
    void Start()
    {
        TutorialSentences = new Queue<string>();
    }

    public void StartTutorialText (TutorialText tutorialtext)
    {
        animator.SetBool("isOpen", true);
        move.isReading = true;

        TutorialSentences.Clear();

        foreach (string TutorialSentence in tutorialtext.TutorialSentences)
        {
            TutorialSentences.Enqueue(TutorialSentence);
        }
        
        DisplayNextTutorialSentence();
    }

    public void DisplayNextTutorialSentence()
    {
        if (TutorialSentences.Count == 0)
        {
            EndTutorialText();
            return;
        }

        string TutorialSentece = TutorialSentences.Dequeue();
        TutorialSpace.text = TutorialSentece;
        // Debug.Log("Test");
    }

    public void EndTutorialText()
    {
        animator.SetBool("isOpen", false);
        move.isReading = false;
    }
}
