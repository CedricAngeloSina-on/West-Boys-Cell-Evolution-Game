using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l1_Quest3 : MonoBehaviour
{
    public PlayerLevel level;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;
    
    void Update()
    {
        if (level.level >= 2 && !questComplete)
        {
            FinishQuest();
            questComplete = true;
        }
    }

    public void FinishQuest()
    {
        questItem.color = completedColor;
    }
}
