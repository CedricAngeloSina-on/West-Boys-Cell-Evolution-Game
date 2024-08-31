using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TutQuest3 : MonoBehaviour
{
    public PlayerLevel level;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    public UnityEvent LevelUp = new UnityEvent();
    
    void Update()
    {
        if (level.level >= 2 && !questComplete)
        {
            LevelUp.Invoke();
            questComplete = true;
        }
    }

    public void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        questItem.color = completedColor;
    }
}
