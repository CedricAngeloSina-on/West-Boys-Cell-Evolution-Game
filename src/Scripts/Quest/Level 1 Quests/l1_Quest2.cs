using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l1_Quest2 : MonoBehaviour
{
    public PlayerScore score;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    void Update()
    {
        if (score.currentPS >= 1 && !questComplete)
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
