using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TutQuest2 : MonoBehaviour
{
    public PlayerScore score;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    public UnityEvent Defeat1Enemy = new UnityEvent();

    void Update()
    {
        if (score.PS >= 1 && !questComplete)
        {
            Defeat1Enemy.Invoke();
            questComplete = true;
        }
    }

    public void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        questItem.color = completedColor;
    }
}
