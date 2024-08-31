using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public PlayerStats stats;

    public List<QnA> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public string ifFailSceneID;
    public string ifPassSceneID;
    public bool isDemo;
    public bool isGoingToLevel2 = false;
    public bool isGoingToLevel3 = false;
    public bool isGoingToLevel4 = false;

    public TMP_Text questionsTxt;
    public TMP_Text scoreTxt;

    public GameObject quizPanel;
    public GameObject evaluationPanel;
    public Button retryButton;
    public Button continueButton;

    int totalQuestions = 0;
    public int totalCorrectAnswers = 0;
    public int scorePercentage = 0;

    void Start()
    {
        totalQuestions = QnA.Count;
        evaluationPanel.SetActive(false);
        quizPanel.SetActive(true);
        GenerateQuestion();
    }

    void GenerateQuestion()
    {
        if (QnA.Count > 0)
        {
        currentQuestion = Random.Range(0, QnA.Count);

        questionsTxt.text = QnA[currentQuestion].questions;
        SetAnswers();
        }
        else
        {
            EndQuiz();
            Debug.Log("No questions available");
        }
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswersScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].answers[i];

            if (QnA[currentQuestion].correctAnswer == i+1)
            {
                options[i].GetComponent<AnswersScript>().isCorrect = true;
            }
        }
    }

    public void Correct()
    {
        totalCorrectAnswers += 1;
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

    public void Wrong()
    {
        QnA.RemoveAt(currentQuestion);
        GenerateQuestion();
    }

    void EndQuiz()
    {
        quizPanel.SetActive(false);
        evaluationPanel.SetActive(true);
        scoreTxt.text = totalCorrectAnswers + "/" + totalQuestions;
        
        if (totalCorrectAnswers > 7)
        {
            continueButton.gameObject.SetActive(true);
            retryButton.gameObject.SetActive(false);
            if (isGoingToLevel3)
            {
                stats.updateCurrentStage("Level 3");
            } else if (isGoingToLevel4)
            {
                stats.updateCurrentStage("Level 4");
            }
        }
        else
        {
            continueButton.gameObject.SetActive(false);
            retryButton.gameObject.SetActive(true);
        }

    }

    void Update()
    {
        if (isDemo)
        {
            ifPassSceneID = "Demo End";
        }
        if (isGoingToLevel2){
            ifFailSceneID = "Level 1";
            if (stats.currentCellClass == "Basic Archaea")
            {
                ifPassSceneID = "Level 2 Archaea";
            } else if (stats.currentCellClass == "Basic Bacteria")
            {
                ifPassSceneID = "Level 2 Bacteria";
            } else if (stats.currentCellClass == "Basic Eukaryote")
            {
                ifPassSceneID = "Level 2 Eukaryote";
            }
        } else if (isGoingToLevel3){
            if (stats.currentCellClass == "Crenarchaeota Cell"){
                ifFailSceneID = "Level 2 Archaea";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Euryarchaeota Cell")
            {
                ifFailSceneID = "Level 2 Archaea";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Chlorobiaceae Cell")
            {
                ifFailSceneID = "Level 2 Bacteria";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Heliobacteria Cell")
            {
                ifFailSceneID = "Level 2 Bacteria";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Cyanobacteria Cell")
            {
                ifFailSceneID = "Level 2 Bacteria";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Proteobacteria Cell")
            {
                ifFailSceneID = "Level 2 Bacteria";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Plant Cell")
            {
                ifFailSceneID = "Level 2 Eukaryote";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Animal Cell")
            {
                ifFailSceneID = "Level 2 Eukaryote";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Fungi Cell")
            {
                ifFailSceneID = "Level 2 Eukaryote";
                ifPassSceneID = "Level 3";
            } else if (stats.currentCellClass == "Protist Cell")
            {
                ifFailSceneID = "Level 2 Eukaryote";
                ifPassSceneID = "Level 3";
            }
        } else if (isGoingToLevel4)
        {
            ifFailSceneID = "Level 3";
            ifPassSceneID = "Level 4";
        }
        
    }

    public void Retry()
    {
        SceneManager.LoadScene(ifFailSceneID);
    }
    
    public void Continue()
    {
        SceneManager.LoadScene(ifPassSceneID);
    }
}
