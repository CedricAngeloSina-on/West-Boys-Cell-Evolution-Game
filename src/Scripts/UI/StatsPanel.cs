using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsPanel : MonoBehaviour
{
    public PlayerScore score;
    public PlayerStats stats;

    public TMP_Text EStext, AStext, PStext, cellName, cellBackground, vitText, defText, speedText;
    // Update is called once per frame
    void Update()
    {
        EStext.text = score.ES.ToString();
        AStext.text = score.AS.ToString();
        PStext.text = score.PS.ToString();
        cellName.text = stats.currentCellClass;
        stats.CBackground();
        vitText.text = "Vitality: " + stats.Vitality.ToString();
        defText.text = "Defense: " + stats.Defense.ToString();
        speedText.text = "Speed: " + stats.Speed.ToString();
    }
}
