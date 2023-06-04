using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TutQuest4 : MonoBehaviour
{
    public PlayerLevel level;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    public UnityEvent ReachLevel10 = new UnityEvent();
    
    void Update()
    {
        if(level.level >= 10 && !questComplete)
        {
            ReachLevel10.Invoke();
            questComplete = true;
        }
    }

    public void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        questItem.color = completedColor;
    }
}
