using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayTutorial()
    {
        SceneManager.LoadScene("Tutorial Stage");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ReturnToMM()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ReturnToTitleScreen()
    {
        SceneManager.LoadScene("Main Menu Demo");
    }
    
    public void GoToEndDemoScreen()
    {
        SceneManager.LoadScene("Demo End");
    }
}
