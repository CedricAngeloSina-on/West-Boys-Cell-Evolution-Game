using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hover_Skill_Arch : MonoBehaviour
{
    public Skill_Tree_Arch skillTree;
    public PlayerLevel level;

    public Image skillImage;
    public TMP_Text skillName;
    public TMP_Text skillDescription;
    public TMP_Text skillPointRequirements;
    public Sprite[] skillSprites;

    void Awake()
    {
        skillTree = GetComponent<Skill_Tree_Arch>();
    }

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
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock01Req.ToString();
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
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock02Req.ToString();
    }

    public void HoverCapsule()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[2];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Capsule II";
        skillDescription.text = "The capsule helps prokaryotes cling to each other and to various surfaces in their environment, and also helps prevent the cell from drying out.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock03Req.ToString();
    }
    
    public void HoverCytoplasm()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[3];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cytoplasm II";
        skillDescription.text = "Cytoplasm is the gelatinous liquid that fills the inside of a cell. It is composed of water, salts, and various organic molecules.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock04Req.ToString();
    }

    public void HoverNucleoid()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[4];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Nucleoid II";
        skillDescription.text = "The nucleoid functions much like the nucleus in eukaryotic cells in that it is the regulatory center of the prokaryotic cell.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock05Req.ToString();
    }

    public void HoverPili()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[5];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Pili II";
        skillDescription.text = "Pili provide cells with a link to their external environments by enabling them to interact with, and attach to, host cells, other surfaces or each other, or by providing a conduit for secretion.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock06Req.ToString();
    }

    public void HoverFlagella()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[6];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Flagella II";
        skillDescription.text = "Flagella are microscopic hair-like structures involved in the locomotion of a cell. The word “flagellum” means “whip”.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock07Req.ToString();
    }

    public void HoverRibosome()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[7];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Ribosome II";
        skillDescription.text = "A ribosome is an intercellular structure made of both RNA and protein, and it is the site of protein synthesis in the cell. ";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock08Req.ToString();
    }

    public void HoverDNA()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[8];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "DNA II";
        skillDescription.text = "DNA contains the instructions needed for an organism to develop, survive and reproduce.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock09Req.ToString();
    }

    public void HoverPlasmid()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[9];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Plasmid II";
        skillDescription.text = "A plasmid is a small circular DNA molecule found in bacteria and some other microscopic organisms. Plasmids are physically separate from chromosomal DNA and replicate independently.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock10Req.ToString();
    }

    public void HoverCellularRespiration()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[10];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cellular Respiration";
        skillDescription.text = "Cellular respiration is a series of chemical reactions that break down glucose to produce ATP, which may be used as energy to power many reactions throughout the body.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock11Req.ToString();
    }
}
