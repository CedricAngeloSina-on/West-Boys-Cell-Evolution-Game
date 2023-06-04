using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Evolution_04 : MonoBehaviour
{
    public PlayerLevel level;
    public PlayerStats stats;

    public TMP_Text EvolName;
    public TMP_Text EvolDesc;
    public Image EImage;
    public GameObject EvolPanel;

    public GameObject BasicEukarya, PlantCell, AnimalCell, FungiCell, ProtistCell;

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

    public void EvolvePlantCell()
    {
        Destroy(BasicEukarya);
        Destroy(AnimalCell);
        Destroy(FungiCell);
        Destroy(ProtistCell);
        PlantCell.SetActive(true);
        stats.changeCellClass("Plant Cell");
    }

    public void EvolveAnimalCell()
    {
        Destroy(BasicEukarya);
        Destroy(PlantCell);
        Destroy(FungiCell);
        Destroy(ProtistCell);
        AnimalCell.SetActive(true);
        stats.changeCellClass("Animal Cell");
    }

    public void EvolveFungiCell()
    {
        Destroy(BasicEukarya);
        Destroy(PlantCell);
        Destroy(AnimalCell);
        Destroy(ProtistCell);
        FungiCell.SetActive(true);
        stats.changeCellClass("Fungi Cell");
    }

    public void EvolveProtistCell()
    {
        Destroy(BasicEukarya);
        Destroy(PlantCell);
        Destroy(AnimalCell);
        Destroy(FungiCell);
        ProtistCell.SetActive(true);
        stats.changeCellClass("Protist Cell");
    }

    public void HoverOnPlantCell()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[0];

        EvolName.text = "Plant Cell";
        EvolDesc.text = "Plant cells are the basic unit of life in organisms of the kingdom Plantae. They are eukaryotic cells, which have a true nucleus along with specialized structures called organelles that carry out different functions. Plant cells have special organelles called chloroplasts, which create sugars via photosynthesis. They also have a cell wall that provides structural support.";
    }

    public void HoverOnAnimalCell()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[1];

        EvolName.text = "Animal Cell";
        EvolDesc.text = "Animal cells are the basic unit of life in organisms of the kingdom Animalia. They are eukaryotic cells, meaning that they have a true nucleus and specialized structures called organelles that carry out different functions. Animal cells do not have plant-specific organelles like cell walls, which support the plant cell, or chloroplasts, the organelle that carries out photosynthesis.";
    }

    public void HoverOnFungiCell()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[2];

        EvolName.text = "Fungi Cell";
        EvolDesc.text = "Fungi are a kingdom of usually multicellular eukaryotic organisms that are heterotrophs and have important roles in nutrient cycling in an ecosystem. Fungi reproduce both sexually and asexually, and they also have symbiotic associations with plants and bacteria. However, they are also responsible for some diseases in plants and animals.";
    }

    public void HoverOnProtistCell()
    {
        EvolName.enabled = true;
        EvolDesc.enabled = true;
        EImage.sprite = EvolSprites[3];

        EvolName.text = "Protist Cell";
        EvolDesc.text = "Protists are a group of loosely connected, mostly unicellular eukaryotic organisms that are not plants, animals or fungi. There is no single feature such as evolutionary history or morphology common to all these organisms and they are unofficially placed under a separate kingdom called Protista.";
    }

    public void HoverExit()
    {
        EvolName.text = "";
        EvolDesc.text = "";
        EImage.sprite = null;
    }
}
