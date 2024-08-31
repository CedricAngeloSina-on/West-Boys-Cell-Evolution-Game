using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswersScript : MonoBehaviour
{
    public bool isCorrect;
    public QuizManager quizManager;

    public void Answer()
    {
        if (isCorrect)
        {
            Debug.Log("Correct!");
            quizManager.Correct();
        }
        else
        {
            Debug.Log("Wrong!");
            quizManager.Wrong();
        }
    }
}
