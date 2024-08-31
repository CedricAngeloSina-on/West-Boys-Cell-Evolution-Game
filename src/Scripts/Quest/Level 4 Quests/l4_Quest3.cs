using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l4_Quest3 : MonoBehaviour
{
    public TimerScript time;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;
    
    void Update()
    {
        
        if (time.currentTime >= 180 && !questComplete)
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
