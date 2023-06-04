using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skill_Tree_Arch : MonoBehaviour
{
    public PlayerLevel lvlsystem;
    public PlayerStats stats;
    public Consume basic, crenar, euryar;

    public TMP_Text SPText;

    public Button Button01, Button02, Button03, Button04, Button05, Button06, 
    Button07, Button08, Button09, Button10, Button11;
    
    [HideInInspector]
    public bool isAcquiredS01, isAcquiredS02, isAcquiredS03, isAcquiredS04, isAcquiredS05, isAcquiredS06, isAcquiredS07,
    isAcquiredS08, isAcquiredS09, isAcquiredS10, isAcquiredS11;

    public int Unlock01Req, Unlock02Req, Unlock03Req, Unlock04Req, Unlock05Req, Unlock06Req, Unlock07Req,
    Unlock08Req, Unlock09Req, Unlock10Req, Unlock11Req;
    
    public static int CurrentSkillPoints;
    public static int TotalSpentSP = 0;
    public int currentSpentSP = 0;

    void Update()
    {
        CurrentSkillPoints = lvlsystem.SkillPoints;
        SPText.text = "SP: " + CurrentSkillPoints.ToString();
        
        if (lvlsystem.SkillPoints >= Unlock01Req)
        {
            Button01.interactable = true;
        } else 
        {
            Button01.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock02Req)
        {
            Button02.interactable = true;
        } else 
        {
            Button02.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock03Req)
        {
            Button03.interactable = true;
        } else 
        {
            Button03.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock04Req)
        {
            Button04.interactable = true;
        } else 
        {
            Button04.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock05Req)
        {
            Button05.interactable = true;
        } else 
        {
            Button05.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock06Req)
        {
            Button06.interactable = true;
        } else 
        {
            Button06.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock07Req)
        {
            Button07.interactable = true;
        } else 
        {
            Button07.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock08Req)
        {
            Button08.interactable = true;
        } else 
        {
            Button08.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock09Req)
        {
            Button09.interactable = true;
        } else 
        {
            Button09.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock10Req)
        {
            Button10.interactable = true;
        } else 
        {
            Button10.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock11Req)
        {
            Button11.interactable = true;
        } else 
        {
            Button11.interactable = false;
        }
        
        if (isAcquiredS01)
        {
            Button01.interactable = false;
        }
        if (isAcquiredS02)
        {
            Button02.interactable = false;
        }
        if (isAcquiredS03)
        {
            Button03.interactable = false;
        }
        if (isAcquiredS04)
        {
            Button04.interactable = false;
        }
        if (isAcquiredS05)
        {
            Button05.interactable = false;
        }
        if (isAcquiredS06)
        {
            Button06.interactable = false;
        }
        if (isAcquiredS07)
        {
            Button07.interactable = false;
        }
        if (isAcquiredS08)
        {
            Button08.interactable = false;
        }
        if (isAcquiredS09)
        {
            Button09.interactable = false;
        }
        if (isAcquiredS10)
        {
            Button10.interactable = false;
        }
        if (isAcquiredS11)
        {
            Button11.interactable = false;
        }
    }

    public void UnlockSkill01()
    {
        stats.Defense += 5;
        lvlsystem.SkillPoints -= Unlock01Req;
        currentSpentSP += Unlock01Req;
        TotalSpentSP += Unlock01Req;
        isAcquiredS01 = true;
    }

    public void UnlockSkill02()
    {
        stats.Defense += 5;
        lvlsystem.SkillPoints -= Unlock02Req;
        currentSpentSP += Unlock02Req;
        TotalSpentSP += Unlock02Req;
        isAcquiredS02 = true;
    }

    public void UnlockSkill03()
    {
        stats.Defense += 5;
        lvlsystem.SkillPoints -= Unlock03Req;
        currentSpentSP += Unlock03Req;
        TotalSpentSP += Unlock03Req;
        isAcquiredS03 = true;
    }

    public void UnlockSkill04()
    {
        stats.Vitality += 4;
        lvlsystem.SkillPoints -= Unlock04Req;
        currentSpentSP += Unlock04Req;
        TotalSpentSP += Unlock04Req;
        isAcquiredS04 = true;
    }

    public void UnlockSkill05()
    {
        stats.Vitality += 4;
        lvlsystem.SkillPoints -= Unlock05Req;
        currentSpentSP += Unlock05Req;
        TotalSpentSP += Unlock05Req;
        isAcquiredS05 = true;
    }
    
    public void UnlockSkill06()
    {
        stats.Speed += .9f;
        lvlsystem.SkillPoints -= Unlock06Req;
        currentSpentSP += Unlock06Req;
        TotalSpentSP += Unlock06Req;
        isAcquiredS06 = true;
    }

    public void UnlockSkill07()
    {
        stats.Speed += .9f;
        lvlsystem.SkillPoints -= Unlock07Req;
        currentSpentSP += Unlock07Req;
        TotalSpentSP += Unlock07Req;
        isAcquiredS07 = true;
    }

    public void UnlockSkill08()
    {
        basic.flatXpPerFood *= 1.2f;
        crenar.flatXpPerFood *= 1.2f;
        euryar.flatXpPerFood *= 1.2f;
        lvlsystem.SkillPoints -= Unlock08Req;
        currentSpentSP += Unlock08Req;
        TotalSpentSP += Unlock08Req;
        isAcquiredS08 = true;
    }

    public void UnlockSkill09()
    {
        basic.flatXpPerFood *= 1.2f;
        crenar.flatXpPerFood *= 1.2f;
        euryar.flatXpPerFood *= 1.2f;
        lvlsystem.SkillPoints -= Unlock09Req;
        currentSpentSP += Unlock09Req;
        TotalSpentSP += Unlock09Req;
        isAcquiredS09 = true;
    }
    
    public void UnlockSkill10()
    {
        basic.flatXpPerFood *= 1.2f;
        crenar.flatXpPerFood *= 1.2f;
        euryar.flatXpPerFood *= 1.2f;
        lvlsystem.SkillPoints -= Unlock10Req;
        currentSpentSP += Unlock10Req;
        TotalSpentSP += Unlock10Req;
        isAcquiredS10 = true;
    }

    public void UnlockSkill11()
    {
        stats.Aerobic = true;
        lvlsystem.SkillPoints -= Unlock11Req;
        currentSpentSP += Unlock11Req;
        TotalSpentSP += Unlock11Req;
        isAcquiredS11 = true;
    }
}
