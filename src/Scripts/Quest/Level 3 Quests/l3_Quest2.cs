using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l3_Quest2 : MonoBehaviour
{
    public PlayerLevel level;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    void Update()
    {
        if (level.level >= 10 && !questComplete)
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
