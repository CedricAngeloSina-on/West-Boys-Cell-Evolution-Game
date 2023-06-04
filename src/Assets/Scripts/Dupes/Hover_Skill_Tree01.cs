using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Hover_Skill_Tree01 : MonoBehaviour
{
    public Skill_Tree01 skillTree;
    public PlayerLevel level;

    public Image skillImage;
    public TMP_Text skillName;
    public TMP_Text skillDescription;
    public TMP_Text skillPointRequirements;
    public Sprite[] skillSprites;

    void Start()
    {
        HoverExit();
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
        skillName.text = "Plasma Membrane I";
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
        skillName.text = "Cell Wall I";
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
        skillName.text = "Capsule I";
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
        skillName.text = "Cytoplasm I";
        skillDescription.text = "Cytoplasm is the gelatinous liquid that fills the inside of a cell. It is composed of water, salts, and various organic molecules.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock04Req.ToString();
    }

    public void HoverMitochondria()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[4];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Mitochondria I";
        skillDescription.text = "Mitochondria are membrane-bound cell organelles (mitochondrion, singular) that generate most of the chemical energy needed to power the cell's biochemical reactions. ";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock05Req.ToString();
    }

    public void HoverNucleus()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[5];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Nucleus I";
        skillDescription.text = "The nucleus controls and regulates the activities of the cell (e.g., growth and metabolism) and carries the genes, structures that contain the hereditary information.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock06Req.ToString();
    }

    public void HoverCytoskeleton()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[6];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Cytoskeleton I";
        skillDescription.text = "The cytoskeleton is a structure that helps cells maintain their shape and internal organization, and it also provides mechanical support that enables cells to carry out essential functions like division and movement.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock07Req.ToString();
    }

    public void HoverPili()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[7];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Pili I";
        skillDescription.text = "Pili provide cells with a link to their external environments by enabling them to interact with, and attach to, host cells, other surfaces or each other, or by providing a conduit for secretion.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock08Req.ToString();
    }

    public void HoverFlagella()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[8];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Flagella I";
        skillDescription.text = "Flagella are microscopic hair-like structures involved in the locomotion of a cell. The word “flagellum” means “whip”.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock09Req.ToString();
    }

    public void HoverRibosome()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[9];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Ribosome I";
        skillDescription.text = "A ribosome is an intercellular structure made of both RNA and protein, and it is the site of protein synthesis in the cell. ";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock10Req.ToString();
    }

    public void HoverDNA()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[10];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "DNA I";
        skillDescription.text = "DNA contains the instructions needed for an organism to develop, survive and reproduce.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock11Req.ToString();
    }

    public void HoverPlasmid()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[11];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "Plasmid I";
        skillDescription.text = "A plasmid is a small circular DNA molecule found in bacteria and some other microscopic organisms. Plasmids are physically separate from chromosomal DNA and replicate independently.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock12Req.ToString();
    }

    public void EndoSymbiosis()
    {
        skillImage.enabled = true;
        skillImage.sprite = skillSprites[12];
        skillName.enabled = true;
        skillDescription.enabled = true;
        skillPointRequirements.enabled = true;
        skillName.text = "EndoSymbiosis I";
        skillDescription.text = "The act where one cell engulfs another such that the engulfed cell survives and both cells benefit. Over many generations, a symbiotic relationship can result in two organisms that depend on each other so completely that neither could survive on its own.";
        skillPointRequirements.text = "SKILL POINTS REQUIRED " + level.SkillPoints + "/" + skillTree.Unlock13Req.ToString();
    }
}
