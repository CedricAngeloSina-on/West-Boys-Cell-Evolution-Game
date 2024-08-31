using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMode : MonoBehaviour
{
    public PlayerLevel level;
    public PlayerHealth health;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            level.GainExperienceFlatRate(1000);
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            level.GainExperienceFlatRate(100);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            level.SkillPoints += 10;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            health.TakeDamage(Random.Range(5, 10));
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            health.RestoreHealth(Random.Range(5, 10));
        }
        /*if (Input.GetKeyDown(KeyCode.V))
        {
            SceneManager.LoadScene("Level 1");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("Level 2 (Eukarya)");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level 3");
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Level 4");
        }*/

    }
}
