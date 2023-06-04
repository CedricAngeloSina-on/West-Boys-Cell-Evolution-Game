using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public PlayerStats stats;

    public static int EndoScore = 0;
    //Endocytosis is scored via eating raw materials/energy
    public static float AutoScore = 0f;
    //Autotrophic is scored via generating your own energy/food
    public static int PhagoScore = 0;
    //Phagocytosis is scored via eating other cells
    
    public int ES,AS,PS, currentPS;
    public int increasePerSecond;

    void Awake()
    {
        // stats = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    void Update()
    {
        ES = EndoScore;
        AS = (int)AutoScore;
        PS = PhagoScore;

        if (stats.Autotrophic == true)
        {
            IncreaseAutoScore();
        }
    }

    public void IncreaseEndoScore(int value)
    {
        EndoScore += value;
    }

    public void IncreaseAutoScore()
    {
        AutoScore += increasePerSecond * Time.deltaTime;
    }

    public void IncreasePhagoScore(int value)
    {
        PhagoScore += value;
        currentPS += value;
    }

    public void TotalReset()
    {
        EndoScore = 0;
        AutoScore = 0;
        PhagoScore = 0;
    }
}
