using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassiveFoodGen : MonoBehaviour
{
    //public PlayerLevel level;
    public PlayerScore scoring;
    public Text score;

    public float increasePerSecond;
    private float AutotrophicScore;

    public bool isAutotrophic;

    void Update()
    {
        score.text = AutotrophicScore.ToString();
        if (isAutotrophic == true)
        {
        AutotrophicScore += increasePerSecond * Time.deltaTime;
        }
    }
}
