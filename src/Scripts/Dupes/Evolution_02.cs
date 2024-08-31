using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Evolution_02 : MonoBehaviour
{
    public PlayerLevel level;
    public PlayerStats stats;

    public TMP_Text EvolName;
    public TMP_Text EvolDesc;
    public Image EImage;
    public GameObject EvolPanel;

    public GameObject BArchaea, Crenarchaeota, Euryarchaeota;

    public Sprite[] EvolSprites;
    
    public bool isEvolving;

    void Start()
    {
        EvolName.enabled = false;
        EvolDesc.enabled = false;
    }

    void Update()
    {
        if (level.level == 10 && !isEvolving)
        {
            EvolPanel.SetActive(true);
            isEvolving = true;
        }
    }

    public void EvolveCrenarchaeota()
    {
        Destroy(BArchaea);
        Destroy(Euryarchaeota);
        Crenarchaeota.SetActive(true);
        stats.changeCellClass("Crenarchaeota Cell");

    }

    public void EvolveEuryarcheota()
    {
        Destroy(BArchaea);
        Destroy(Crenarchaeota);
        Euryarchaeota.SetActive(true);
        stats.changeCellClass("Euryarchaeota Cell");
    }

    public void HoverOnCrenarcheota()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[0];

        EvolName.text = "Crenarchaeota Cell";
        EvolDesc.text = "Crenarchaeota  are thermophilic and acidophilic. They occur in acidic thermal springs and mudpots and in submarine hydrothermal vents. Growth temperatures can exceed 100 °C where hydrostatic pressure prevents boiling. Most Crenarchaeota are anaerobic.<br> Many Crenarchaeota have unusual cell shapes, including filaments and irregular discs, although rods and irregular cocci are common.";
    }

    public void HoverOnEuryarcheota()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[1];

        EvolName.text = "Euryarchaeota Cell";
        EvolDesc.text = "The Euryarchaeota form a physiologically heterogeneous group and includes aerobes as well as anaerobes, chemoautotrophs as well as heterotrophs. All known methanogenic and all extremely halophilic Archaea known belong to the Euryarchaeota phylum. Many Euryarchaeota are extreme thermophiles.";
    }

    public void HoverExit()
    {
        EvolName.text = "";
        EvolDesc.text = "";
        EImage.sprite = null;
    }
}
