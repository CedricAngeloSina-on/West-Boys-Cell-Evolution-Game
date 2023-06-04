using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Evolution_01 : MonoBehaviour
{
    public Skill_Tree01 STree;
    public PlayerLevel level;
    public PlayerStats stats;

    public TMP_Text EvolName;
    public TMP_Text EvolDesc;
    public Image EImage;
    public Button Eukarya;
    public GameObject EvolPanel;

    public Sprite[] EvolSprites;

    [HideInInspector]
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

        if (STree.isAcquiredS13 == true)
        {
            Eukarya.interactable = true;
        }
        else{
            Eukarya.interactable = false;
        }
    }

    public void EvolveBacteria()
    {
        SceneManager.LoadScene("Level 1 Quiz");
        stats.changeCellClass("Basic Bacteria");
        stats.updateCurrentStage("Level 2 Bacteria");
        Debug.Log("Evolved");
    }

    public void EvolveArchaea()
    {
        SceneManager.LoadScene("Level 1 Quiz");
        stats.changeCellClass("Basic Archaea");
        stats.updateCurrentStage("Level 2 Archaea");
        Debug.Log("Evolved");
    }

    public void EvolveEukarya()
    {
        SceneManager.LoadScene("Level 1 Quiz");
        stats.changeCellClass("Basic Eukaryote");
        stats.updateCurrentStage("Level 2 Eukaryote");
        Debug.Log("Evolved");
    }

    public void HoverOnBacteria()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[0];

        EvolName.text = "Bacteria";
        EvolDesc.text = "Bacteria are prokaryotic unicellular organisms. They have a relatively simple cell structure compared to eukaryotic cells. They also do not possess any membrane-bound organelles such as a nucleus. However, do they possess genetic material (DNA or RNA) in the intracellular space called the nucleoid. ";
    }

    public void HoverOnArchaea()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[1];

        EvolName.text = "Archaea";
        EvolDesc.text = "Archaea are microorganisms that define the limits of life on Earth. They were originally discovered and described in extreme environments, such as hydrothermal vents and terrestrial hot springs. They were also found in a diverse range of highly saline, acidic, and anaerobic environments.";
    }

    public void HoverOnEukarya()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[2];

        EvolName.text = "Eukarya";
        EvolDesc.text = "Eukaryote refers to any of the single-celled or multicellular organisms whose cell contains a distinct, membrane-bound nucleus. Organisms such as animals, plants, fungi, and protists are examples of eukaryotes because their cells are organized into compartmentalized structures called organelles, such as the nucleus.";
    }

    public void HoverExit()
    {
        EvolName.text = "";
        EvolDesc.text = "";
        EImage.sprite = null;
    }
}
