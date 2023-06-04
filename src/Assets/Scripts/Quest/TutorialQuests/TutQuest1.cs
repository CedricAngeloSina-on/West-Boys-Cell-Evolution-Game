using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TutQuest1 : MonoBehaviour
{
    public PlayerScore score;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    public UnityEvent Eat10Food = new UnityEvent();

    void Update()
    {
        if (score.ES >= 10 && !questComplete)
        {
            Eat10Food.Invoke();
            questComplete = true;
        }
    }

    public void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        questItem.color = completedColor;
    }
}
