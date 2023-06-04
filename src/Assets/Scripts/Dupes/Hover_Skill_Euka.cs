using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hover_Skill_Euka : MonoBehaviour
{
    public Skill_Tree_Euka ST;
    public PlayerLevel level;

    public Image skillImage;
    public TMP_Text skillName;
    public TMP_Text skillDescription;
    public TMP_Text skillPointRequirements;
    public Sprite[] skillSprites;

    public void HoverExit()
    {
        skillImage.enabled = false;
        skillName.enabled = false;
        skillDescription.enabled = false;
        skillPointRequirements.enabled = false;
    }

    public void HoverPlasmaMembrane()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[0];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Plasma Membrane II";
        skillDescription.text = "The plasma membrane, also called the cell membrane or cytoplasmic membrane, is the membrane found in all cells that separates the interior of the cell from the outside environment.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock01Req.ToString();
    }

    public void HoverCellWall()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[1];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cell Wall II";
        skillDescription.text = "The cell wall surrounds the plasma membrane of plant cells and provides tensile strength and protection against mechanical and osmotic stress.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock02Req.ToString();
    }

    public void HoverLysosome()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[2];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Lysosome I";
        skillDescription.text = "A lysosome is a membrane-bound cell organelle that contains digestive enzymes. Lysosomes are involved with various cell processes. They break down excess or worn-out cell parts. They may be used to destroy invading viruses and bacteria.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock03Req.ToString();
    }

    public void HoverChitinWall()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[3];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Chitin Wall II";
        skillDescription.text = "Chitin is used to create a cell wall. Much like cellulose in plants, the chitin is deposited extracellularly with proteins and other molecules. This forms a rigid cell wall between cells, which help the organisms retain their shape.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock04Req.ToString();
    }
    
    public void HoverCytoplasm()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[4];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cytoplasm II";
        skillDescription.text = "Cytoplasm is the gelatinous liquid that fills the inside of a cell. It is composed of water, salts, and various organic molecules.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock05Req.ToString();
    }

    public void HoverNucleus()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[5];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Nucleus II";
        skillDescription.text = "The nucleus controls and regulates the activities of the cell (e.g., growth and metabolism) and carries the genes, structures that contain the hereditary information. Nucleoli are small bodies often seen within the nucleus.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock06Req.ToString();
    }

    public void HoverMitochondia()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[6];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Mitochondria II";
        skillDescription.text = "Mitochondria are membrane-bound cell organelles (mitochondrion, singular) that generate most of the chemical energy needed to power the cell's biochemical reactions.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock07Req.ToString();
    }

    public void HoverVacuoles()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[7];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Vacuoles II";
        skillDescription.text = "A vacuole is a membrane-bound cell organelle. In animal cells, vacuoles are generally small and help sequester waste products.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock08Req.ToString();
    }

    public void HoverCilia()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[8];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cilia II";
        skillDescription.text = "The function of Cilia is to move water relative to the cell in a regular movement of the cilia. This process can either result in the cell moving through the water, typical for many single-celled organisms, or in moving water and its contents across the surface of the cell.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock09Req.ToString();
    }

    public void HoverFlagella()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[9];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Flagella II";
        skillDescription.text = "Flagella are microscopic hair-like structures involved in the locomotion of a cell. The word “flagellum” means “whip”.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock10Req.ToString();
    }

    public void HoverPseudopodia()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[10];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Pseudopodia II";
        skillDescription.text = "The pseudopodia extends from the two sides of the food molecule and surrounds it and finally engulfs the food. Hence, pseudopodia is used in movement and as a tool to capture prey or obtain required nutrition.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock11Req.ToString();
    }

    public void HoverRibosome()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[11];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Ribosome II";
        skillDescription.text = "A ribosome is an intercellular structure made of both RNA and protein, and it is the site of protein synthesis in the cell. ";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock12Req.ToString();
    }

    public void HoverPlastid()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[12];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Plastid II";
        skillDescription.text = "DNA contains the instructions needed for an organism to develop, survive and reproduce.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock13Req.ToString();
    }

    public void HoverChloroplast()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[13];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Chloroplast II";
        skillDescription.text = "A plasmid is a small circular DNA molecule found in bacteria and some other microscopic organisms. Plasmids are physically separate from chromosomal DNA and replicate independently.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock14Req.ToString();
    }

    public void HoverPeroxisome()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[14];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Peroxisome II";
        skillDescription.text = "Peroxisomes are organelles that sequester diverse oxidative reactions and play important roles in metabolism, reactive oxygen species detoxification, and signaling.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock15Req.ToString();
    }

    public void HoverCellularRespiration()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[15];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cellular Respiration";
        skillDescription.text = "Cellular respiration is a series of chemical reactions that break down glucose to produce ATP, which may be used as energy to power many reactions throughout the body.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock16Req.ToString();
    }
    

    public void HoverCentrosome()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[14];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Centrosome II";
        skillDescription.text = "Centrosome is an organelle that serves as the main microtubule organizing center (MTOC) of the animal cell, as well as a regulator of cell-cycle progression. The centrosome provides structure for the cell. The centrosome is thought to have evolved only in the metazoan lineage of eukaryotic cells.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + ST.Unlock17Req.ToString();
    }

}
