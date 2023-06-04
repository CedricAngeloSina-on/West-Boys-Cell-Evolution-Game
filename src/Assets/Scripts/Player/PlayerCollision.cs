using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerHealth health;
    public PlayerStats stats;

    private float damage;
    public float attack = 10;

    [SerializeField] private float iFramesDuration;
    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriteRend;

    void Awake()
    {
        spriteRend = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {
        if (attack >= stats.Defense) {
            damage = attack * 2 - stats.Defense;
        } else {
            damage = attack * attack / stats.Defense;
        }
    }


    public void OnCollisionStay2D (Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            health.TakeDamage(damage);
            StartCoroutine(Invulnerability());
        }
    }
    
    private IEnumerator Invulnerability()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);

        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f);
            yield return new WaitForSeconds (iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white;
            yield return new WaitForSeconds (iFramesDuration / (numberOfFlashes * 2));
        }

        Physics2D.IgnoreLayerCollision(8, 9, false);
    }
}
