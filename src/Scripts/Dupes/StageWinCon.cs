using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageWinCon : MonoBehaviour
{
    public PlayerLevel level;
    public PlayerStats stats;
    
    public bool hasWon;
    public int levelWinCondition;
    public string nextLevelName;

    void Update()
    {
        if (level.level == levelWinCondition && !hasWon)
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
