using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomFacts : MonoBehaviour
{
    public int randomNumber;
    public TMP_Text randomFacts;
    public bool genFacts;
    [TextArea(3, 10)]
    public string[] facts;

    void Update()
    {
        if (genFacts == false)
        {
            genFacts = true;
            StartCoroutine(randomFactsTracker());
        }
    }

    IEnumerator randomFactsTracker()
    {
        randomNumber = Random.Range(0, facts.Length);
        randomFacts.text = facts[randomNumber];
        yield return new WaitForSeconds(9);
        genFacts = false;
    }
}
