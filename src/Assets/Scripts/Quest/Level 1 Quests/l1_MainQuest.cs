using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class l1_MainQuest : MonoBehaviour
{
    public PlayerStats stat;

    public Image questItem;
    public Color completedColor;
    public bool questComplete;

    void Update()
    {
        if (stat.currentCellClass == "Basic Archaea" && !questComplete)
        {
            FinishQuest();
            questComplete = true;
        } else if (stat.currentCellClass == "Basic Bacteria" && !questComplete)
        {
            FinishQuest();
            questComplete = true;
        } else if (stat.currentCellClass == "Basic Eukaryote" && !questComplete)
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
