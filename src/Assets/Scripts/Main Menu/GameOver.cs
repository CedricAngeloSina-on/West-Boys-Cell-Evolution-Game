using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public PlayerStats stats;

    public string SceneName;

    void Start()
    {
        stats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (stats.isCurrentlyOn == "Level 1")
        {
            SceneName = "Level 1";
        } else if (stats.isCurrentlyOn == "Level 2 Archaea")
        {
            SceneName = "Level 2 Archaea";
        } else if (stats.isCurrentlyOn == "Level 2 Bacteria")
        {
            SceneName = "Level 2 Bacteria";
        } else if (stats.isCurrentlyOn == "Level 2 Eukaryote")
        {
            SceneName = "Level 2 Eukaryote";
        } else if (stats.isCurrentlyOn == "Level 3")
        {
            SceneName = "Level 3";
        } else if (stats.isCurrentlyOn == "Level 4")
        {
            SceneName = "Level 4";
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
