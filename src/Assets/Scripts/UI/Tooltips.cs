using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltips : MonoBehaviour
{
    public TMP_Text tooltipText;
    public string[] randomTooltips;

    void Start()
    {
        tooltipText.text = randomTooltips[Random.Range(0, randomTooltips.Length)];
    }
}
