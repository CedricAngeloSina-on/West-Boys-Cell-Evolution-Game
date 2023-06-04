using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTextTrigger : MonoBehaviour
{
    public TutorialText tutorialtext;

    public void TriggerText ()
    {
        FindObjectOfType<TutorialTextManager>().StartTutorialText(tutorialtext);
    }
}
