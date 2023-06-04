using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l2_Quest4 : MonoBehaviour
{
    public Skill_Tree_Arch ST_Arch;
    public Skill_Tree_Bact ST_Bact;
    public Skill_Tree_Euka ST_Euka;
    
    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    void Update()
    {
        if (ST_Arch != null)
        {
            if (ST_Arch.currentSpentSP > 2 && !questComplete)
            {
                FinishQuest();
                questComplete = true;
            }
        }else if (ST_Bact != null)
        {
            if (ST_Bact.currentSpentSP > 2 && !questComplete)
            {
                FinishQuest();
                questComplete = true;
            }
        }else if (ST_Euka != null)
        {
            if (ST_Euka.currentSpentSP > 2 && !questComplete)
            {
                FinishQuest();
                questComplete = true;
            }
        } else {
            return;
        }

        
    }

    public void FinishQuest()
    {
        questItem.color = completedColor;
    }
}
