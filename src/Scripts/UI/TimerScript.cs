using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [Header("Component")]
    public TMP_Text timerText;
    
    [Header("Timer Settings")]
    public float currentTime;

    //surival scoring
    int survivalScore;
    public float multiplier;

    void Update()
    {
        currentTime = currentTime += Time.deltaTime;
        //find a way to save the time record after game
        survivalScore = Mathf.RoundToInt(currentTime * multiplier);

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60); 
        
        timerText.text = string.Format("{00:00} : {01:00}" , minutes, seconds);
    }
}
