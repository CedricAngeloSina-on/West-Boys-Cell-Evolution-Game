using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l3_Quest3 : MonoBehaviour
{
    public Skill_Tree_Euka ST_Euka;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;
    
    void Update()
    {
        if (ST_Euka.currentSpentSP > 4 && !questComplete)
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
