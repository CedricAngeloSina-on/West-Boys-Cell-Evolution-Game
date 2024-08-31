using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    PlayerLevel level;
    PlayerScore scoring;

    [SerializeField]public float maxHealth = 50;
    public float currentHealth;
    
    void Awake()
    {
        level = GameObject.FindWithTag("Player").GetComponent<PlayerLevel>();
        scoring = GameObject.Find("Game Manager").GetComponent<PlayerScore>();
    }

    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(float dmgAmount)
    {
        currentHealth -= dmgAmount;
    }
    public void RestoreHealth(float healAmount)
    {
        currentHealth += healAmount;
    }

    void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }


    private void OnCollisionStay2D (Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            TakeDamage(15);
            if (currentHealth <= 0)
            {
                level.GainExperienceFlatRate(50);
                scoring.IncreasePhagoScore(1);
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.CompareTag("Food"))
        {
            Destroy(other.gameObject);
            RestoreHealth(10);
        } 
    }
}
