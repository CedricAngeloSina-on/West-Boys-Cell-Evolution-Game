using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{   
    [Header("References")]
    public Skill_Tree_Euka skillTree;
    public StatsPanel statsPanel;

    [Header("Stats")]
    public float Vitality = 10;
    public float Defense = 2;
    public float Speed = 4;

    [Header("Classes")]
    public bool Autotrophic = false;
    public bool Aerobic = false;
    
    [Header("Checkers")]
    public static string CellClass = "Last Universal Common Ancestor";
    public string currentCellClass;
    public static string currentStage;
    public string isCurrentlyOn = "Level 1";

    void Update()
    {
        currentCellClass = CellClass;
        isCurrentlyOn = currentStage;
        
        if (skillTree != null)
        {
            if (CellClass == "Plant Cell") // 3 4 17 11
            {
                skillTree.Button03.gameObject.SetActive(false);
                skillTree.Button04.gameObject.SetActive(false);
                skillTree.Button11.gameObject.SetActive(false);
                skillTree.Button17.gameObject.SetActive(false);
            }
            else if (CellClass == "Animal Cell") //2 13 14 11
            {
                skillTree.Button02.gameObject.SetActive(false);
                skillTree.Button11.gameObject.SetActive(false);
                skillTree.Button13.gameObject.SetActive(false);
                skillTree.Button14.gameObject.SetActive(false);
            }
            else if (CellClass == "Fungi Cell")//3 17 11 13 14
            {
                skillTree.Button03.gameObject.SetActive(false);
                skillTree.Button11.gameObject.SetActive(false);
                skillTree.Button13.gameObject.SetActive(false);
                skillTree.Button14.gameObject.SetActive(false);
                skillTree.Button17.gameObject.SetActive(false);
            }
            else if (CellClass == "Protist Cell")
            {
                skillTree.Button03.gameObject.SetActive(false);
                skillTree.Button17.gameObject.SetActive(false);
                skillTree.Button13.gameObject.SetActive(false);
                skillTree.Button14.gameObject.SetActive(false);
            }
        } else {
            return;
        }
    }

    public void changeCellClass(string newCellClass)
    {
        CellClass = newCellClass;
    }

    public void updateCurrentStage(string newStage)
    {
        currentStage = newStage;
    }

    public void CBackground()
    {
        if (CellClass == "Last Universal Common Ancestor")
        {
            statsPanel.cellBackground.text = " Around 4 billion years ago there lived a microbe called LUCA — the Last Universal Common Ancestor.<br> There is evidence that it could have lived a somewhat ‘alien’ lifestyle, hidden away deep underground in iron-sulfur rich hydrothermal vents. <br> Anaerobic and autotrophic, it didn’t breath air and made its own food from the dark, metal-rich environment around it. Its metabolism depended upon hydrogen, carbon dioxide and nitrogen, turning them into organic compounds such as ammonia. Most remarkable of all, this little microbe was the beginning of a long lineage that encapsulates all life on Earth.";
        }
        else if (CellClass == "Basic Eukaryote")
        {
            statsPanel.cellBackground.text = "Eukaryote refers to any of the single-celled or multicellular organisms whose cell contains a distinct, membrane-bound nucleus. Organisms such as animals, plants, fungi, and protists are examples of eukaryotes because their cells are organized into compartmentalized structures called organelles, such as the nucleus.";
        }
        else if (CellClass == "Plant Cell")
        {
            statsPanel.cellBackground.text = "Plant cells are the basic unit of life in organisms of the kingdom Plantae. They are eukaryotic cells, which have a true nucleus along with specialized structures called organelles that carry out different functions. Plant cells have special organelles called chloroplasts, which create sugars via photosynthesis. They also have a cell wall that provides structural support.";
        }
        else if (CellClass == "Animal Cell")
        {
            statsPanel.cellBackground.text = "Animal cells are the basic unit of life in organisms of the kingdom Animalia. They are eukaryotic cells, meaning that they have a true nucleus and specialized structures called organelles that carry out different functions. Animal cells do not have plant-specific organelles like cell walls, which support the plant cell, or chloroplasts, the organelle that carries out photosynthesis.";
        }
        else if (CellClass == "Fungi Cell")
        {
            statsPanel.cellBackground.text = "Fungi are a kingdom of usually multicellular eukaryotic organisms that are heterotrophs and have important roles in nutrient cycling in an ecosystem. Fungi reproduce both sexually and asexually, and they also have symbiotic associations with plants and bacteria. However, they are also responsible for some diseases in plants and animals.";
        }
        else if (CellClass == "Protist Cell")
        {
            statsPanel.cellBackground.text = "Protists are a group of loosely connected, mostly unicellular eukaryotic organisms that are not plants, animals or fungi. There is no single feature such as evolutionary history or morphology common to all these organisms and they are unofficially placed under a separate kingdom called Protista.";
        }
        else if (CellClass == "Basic Archaea")
        {
            statsPanel.cellBackground.text = "Archaea are microorganisms that define the limits of life on Earth. They were originally discovered and described in extreme environments, such as hydrothermal vents and terrestrial hot springs. They were also found in a diverse range of highly saline, acidic, and anaerobic environments.";
        }
        else if (CellClass == "Crenarchaeota Cell")
        {
            statsPanel.cellBackground.text = "Crenarchaeota  are thermophilic and acidophilic. They occur in acidic thermal springs and mudpots and in submarine hydrothermal vents. Growth temperatures can exceed 100 °C where hydrostatic pressure prevents boiling. Most Crenarchaeota are anaerobic.<br> Many Crenarchaeota have unusual cell shapes, including filaments and irregular discs, although rods and irregular cocci are common.";
        }
        else if (CellClass == "Euryarchaeota Cell")
        {
            statsPanel.cellBackground.text = "The Euryarchaeota form a physiologically heterogeneous group and includes aerobes as well as anaerobes, chemoautotrophs as well as heterotrophs. All known methanogenic and all extremely halophilic Archaea known belong to the Euryarchaeota phylum. Many Euryarchaeota are extreme thermophiles.";
        }
        else if (CellClass == "Basic Bacteria")
        {
            statsPanel.cellBackground.text = "Bacteria are prokaryotic unicellular organisms. They have a relatively simple cell structure compared to eukaryotic cells. They also do not possess any membrane-bound organelles such as a nucleus. However, do they possess genetic material (DNA or RNA) in the intracellular space called the nucleoid. ";
        }
        else if (CellClass == "Chlorobiaceae Cell")
        {
            statsPanel.cellBackground.text = "Green Sulfur Bacteria of family Chloriobiaceae are nonmotile and capable of anoxygenic photosynthesis.They require anaerobic conditions and use sulphide or sulphur as a source of reduction for photosynthesis. Sulphur is sometimes produced from sulphide, but never inside the cells. <br> These bacteria has a unique feature called Chlorosomes, light-harvesting complexes attached to the cytoplasmic membrane carrying the photosynthetic pigment, which allows them to harvest light in low light environments.";
        }
        else if (CellClass == "Heliobacteria Cell")
        {
            statsPanel.cellBackground.text = "Heliobacteria are a unique subset of prokaryotic bacteria that process light for energy. Distinguishable from other phototrophic bacteria, they utilize a unique photosynthetic pigment, bacteriochlorophyll g and are the only known Gram-positive phototroph.";
        }
        else if (CellClass == "Cyanobacteria Cell")
        {
            statsPanel.cellBackground.text = "Cyanobacteria is a group of photosynthetic bacteria widely distributed in various aquatic habitats  and terrestrial habitats. They may live singly or in colonies. Cyanobacteria are important oxygen producers of the planet. <br> They are one of the oldest life forms on Earth together with the other early prokaryotes. They existed billions of years ago in the early extreme environments before plants and animals emerged.";
        }
        else if (CellClass == "Proteobacteria Cell")
        {
            statsPanel.cellBackground.text = "Proteobacteria are comprised of gram-negative bacteria with an outer membrane consisting largely of lipopolysaccharides. Many of them have flagella used for locomotion. Few of them move through bacterial gliding; others are non-motile. Members of this phylum are anaerobic. Many of which are facultative anaerobes; others are obligate aerobes.";
        }
        else
        {
            statsPanel.cellBackground.text = "Error no known cell class";
        }
    }
}
