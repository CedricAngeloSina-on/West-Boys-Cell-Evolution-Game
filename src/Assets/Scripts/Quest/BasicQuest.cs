using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class BasicQuest : MonoBehaviour
{
    public PlayerLevel level;

    public Image questItem;
    public Color completedColor;

    /*public UnityEvent Eat10Food = new UnityEvent();
    public UnityEvent Defeat1Enemy = new UnityEvent();
    public UnityEvent LevelUp = new UnityEvent();
    public UnityEvent Evolve = new UnityEvent();*/

    /*public Color activeColor;
    public Color currentColor;

    public Quest[] allQuests;

    void Start()
    {
        allQuests = FindObjectsOfType<Quest>();
        currentColor = questItem.color;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            FinishQuest();
            Destroy(gameObject);
        }
    }*/

    void Update()
    {

    }

    void FinishQuest()
    {
        questItem.GetComponent<Button>().interactable = false;
        questItem.color = completedColor;
        //currentColor = completedColor;
    }
    
    /*public void OnQuestClick()
    {
        foreach (Quest quest in allQuests)
        {
            quest.questItem.color = quest.currentColor;
        }
        questItem.color = activeColor;

    }*/
}
