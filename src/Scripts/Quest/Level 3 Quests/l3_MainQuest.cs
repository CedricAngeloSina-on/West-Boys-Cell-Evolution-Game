using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l3_MainQuest : MonoBehaviour
{
    public CountdownTimer time;
    public float setTime;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    void Update()
    {
        if (time.TimeLeft <= setTime && !questComplete)
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
