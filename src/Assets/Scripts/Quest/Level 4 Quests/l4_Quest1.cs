using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l4_Quest1 : MonoBehaviour
{
    public PlayerScore score;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    void Update()
    {
        if (score.ES >= 10 && !questComplete)
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
