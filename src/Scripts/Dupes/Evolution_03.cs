using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Evolution_03 : MonoBehaviour
{
    public PlayerLevel level;
    public PlayerStats stats;

    public TMP_Text EvolName1, EvolName2;
    public TMP_Text EvolDesc1, EvolDesc2;
    public Image EImage1, EImage2;
    public GameObject EvolPanel1,EvolPanel2;

    public GameObject BasicBacteria, Chloro, Helio, Cyano, Proteo;

    public Sprite[] EvolSprites;
    
    public bool isEvolving1;
    public bool isEvolving2;

    void Start()
    {
        EvolName1.enabled = false;
        EvolName2.enabled = false;
        EvolDesc1.enabled = false;
        EvolDesc2.enabled = false;
    }

    void Update()
    {
        if (level.level == 10 && !isEvolving1)
        {
            EvolPanel1.SetActive(true);
            isEvolving1 = true;
        }
        if (level.level == 20 && !isEvolving2)
        {
            EvolPanel2.SetActive(true);
            isEvolving2 = true;
        }
    }

    public void EvolveChlorobiaceae()
    {
        Destroy(BasicBacteria);
        Destroy(Helio);
        // Destroy(Cyano);
        // Destroy(Proteo);
        Chloro.SetActive(true);
        EvolPanel1.SetActive(false);
        stats.changeCellClass("Chlorobiaceae Cell");
    }

    public void EvolveHeliobacteria()
    {
        Destroy(BasicBacteria);
        Destroy(Chloro);
        // Destroy(Cyano);
        // Destroy(Proteo);
        Helio.SetActive(true);
        EvolPanel1.SetActive(false);
        stats.changeCellClass("Heliobacteria Cell");
    }

    public void EvolveCyanobacteria()
    {
        Destroy(BasicBacteria);
        Destroy(Chloro);
        Destroy(Helio);
        Destroy(Proteo);
        Cyano.SetActive(true);
        EvolPanel2.SetActive(false);
        stats.changeCellClass("Cyanobacteria Cell");
        stats.Aerobic = true;
    }

    public void EvolveProteobacteria()
    {
        Destroy(BasicBacteria);
        Destroy(Chloro);
        Destroy(Helio);
        Destroy(Cyano);
        Proteo.SetActive(true);
        EvolPanel2.SetActive(false);
        stats.changeCellClass("Proteobacteria Cell");
    }

    public void HoverOnChlorobiaceae()
    {
        EvolName1.enabled = true;
        EvolDesc1.enabled = true;
        EImage1.sprite = EvolSprites[0];

        EvolName1.text = "Chlorobiaceae Cell";
        EvolDesc1.text = "Green Sulfur Bacteria of family Chloriobiaceae are nonmotile and capable of anoxygenic photosynthesis.They require anaerobic conditions and use sulphide or sulphur as a source of reduction for photosynthesis. Sulphur is sometimes produced from sulphide, but never inside the cells. <br> These bacteria has a unique feature called Chlorosomes, light-harvesting complexes attached to the cytoplasmic membrane carrying the photosynthetic pigment, which allows them to harvest light in low light environments.";
    }

    public void HoverOnHeliobacteria()
    {
        EvolName1.enabled = true;
        EvolDesc1.enabled = true;
        EImage1.sprite = EvolSprites[1];

        EvolName1.text = "Heliobacteria Cell";
        EvolDesc1.text = "Heliobacteria are a unique subset of prokaryotic bacteria that process light for energy. Distinguishable from other phototrophic bacteria, they utilize a unique photosynthetic pigment, bacteriochlorophyll g and are the only known Gram-positive phototroph.";
    }

    public void HoverOnCyanobacteria()
    {
        EvolName2.enabled = true;
        EvolDesc2.enabled = true;
        EImage2.sprite = EvolSprites[2];

        EvolName2.text = "Cyanobacteria Cell";
        EvolDesc2.text = "Cyanobacteria is a group of photosynthetic bacteria widely distributed in various aquatic habitats  and terrestrial habitats. They may live singly or in colonies. Cyanobacteria are important oxygen producers of the planet. <br> They are one of the oldest life forms on Earth together with the other early prokaryotes. They existed billions of years ago in the early extreme environments before plants and animals emerged.";
    }

    public void HoverOnProteobacteria()
    {
        EvolName2.enabled = true;
        EvolDesc2.enabled = true;
        EImage2.sprite = EvolSprites[3];

        EvolName2.text = "Proteobacteria Cell";
        EvolDesc2.text = "Proteobacteria are comprised of gram-negative bacteria with an outer membrane consisting largely of lipopolysaccharides. Many of them have flagella used for locomotion. Few of them move through bacterial gliding; others are non-motile. Members of this phylum are anaerobic. Many of which are facultative anaerobes; others are obligate aerobes.";
    }

    public void HoverExit()
    {
        EvolName1.text = "";
        EvolName2.text = "";
        EvolDesc1.text = "";
        EvolDesc2.text = "";
        EImage1.sprite = null;
        EImage2.sprite = null;
    }
}
