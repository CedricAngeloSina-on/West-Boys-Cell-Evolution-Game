using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour
{   
    public PlayerLevel level;
    public PlayerHealth health;
    public PlayerScore score;

    public float flatXpPerFood = 20;
    public float flatHPRestore = 20;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Food"))
        {
            level.GainExperienceFlatRate(Mathf.Round(flatXpPerFood));
            health.RestoreHealth(flatHPRestore);
            score.IncreaseEndoScore(1);
            Destroy(other.gameObject);
        }
    }
}
