using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestOpen : MonoBehaviour
{
    public GameObject questPanel;

    public void OpenQuestPanel()
    {
        if (questPanel.activeSelf == true)
        {
            questPanel.SetActive(false);
        }
        else 
        {
            questPanel.SetActive(true);
        }
    }
}
