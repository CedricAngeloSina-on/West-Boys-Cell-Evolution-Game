using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skill_Tree01 : MonoBehaviour
{
    public PlayerLevel lvlsystem;
    public PlayerStats stats;
    public Consume eat;

    public TMP_Text SPText;

    public Button Button01, Button02, Button03, Button04, Button05, Button06, Button07, Button08, Button09, 
    Button10, Button11, Button12, Button13;
    
    [HideInInspector]
    public bool isAcquiredS01, isAcquiredS02, isAcquiredS03, isAcquiredS04, isAcquiredS05, isAcquiredS06, isAcquiredS07,
    isAcquiredS08, isAcquiredS09, isAcquiredS10, isAcquiredS11, isAcquiredS12, isAcquiredS13;
    
    public int Unlock01Req, Unlock02Req, Unlock03Req, Unlock04Req, Unlock05Req, Unlock06Req, Unlock07Req,
    Unlock08Req, Unlock09Req, Unlock10Req, Unlock11Req, Unlock12Req, Unlock13Req;

    public static int CurrentSkillPoints;
    public static int TotalSpentSP = 0;

    void Update()
    {
        CurrentSkillPoints = lvlsystem.SkillPoints;
        SPText.text = "SP: " + CurrentSkillPoints.ToString();
        
        //Checks if the player can afford to get the skill
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
        
        if (lvlsystem.SkillPoints >= Unlock12Req)
        {
            Button12.interactable = true;
        } else 
        {
            Button12.interactable = false;
        }
        
        if (lvlsystem.SkillPoints >= Unlock13Req)
        {
            Button13.interactable = true;
        } else 
        {
            Button13.interactable = false;
        }
        
        //Checks if player has already unlocked the skill
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
        if (isAcquiredS12)
        {
            Button12.interactable = false;
        }
        if (isAcquiredS13)
        {
            Button13.interactable = false;
        }
    }

    public void UnlockSkill01()
    {
        stats.Defense += 2;
        lvlsystem.SkillPoints -= Unlock01Req;
        TotalSpentSP += Unlock01Req;
        isAcquiredS01 = true;
    }

    public void UnlockSkill02()
    {
        stats.Defense += 3;
        lvlsystem.SkillPoints -= Unlock02Req;
        TotalSpentSP += Unlock02Req;
        isAcquiredS02 = true;
    }

    public void UnlockSkill03()
    {
        stats.Defense += 4;
        lvlsystem.SkillPoints -= Unlock03Req;
        TotalSpentSP += Unlock03Req;
        isAcquiredS03 = true;
    }

    public void UnlockSkill04()
    {
        stats.Vitality += 2;
        lvlsystem.SkillPoints -= Unlock04Req;
        TotalSpentSP += Unlock04Req;
        isAcquiredS04 = true;
    }

    public void UnlockSkill05()
    {
        stats.Vitality += 4;
        lvlsystem.SkillPoints -= Unlock05Req;
        TotalSpentSP += Unlock05Req;
        isAcquiredS05 = true;
    }

    public void UnlockSkill06()
    {
        stats.Vitality += 6;
        lvlsystem.SkillPoints -= Unlock06Req;
        TotalSpentSP += Unlock06Req;
        isAcquiredS06 = true;
    }

    public void UnlockSkill07()
    {
        stats.Speed += .2f;
        lvlsystem.SkillPoints -= Unlock07Req;
        TotalSpentSP += Unlock07Req;
        isAcquiredS07 = true;
    }

    public void UnlockSkill08()
    {
        stats.Speed += .4f;
        lvlsystem.SkillPoints -= Unlock08Req;
        TotalSpentSP += Unlock08Req;
        isAcquiredS08 = true;
    }

    public void UnlockSkill09()
    {
        stats.Speed += .6f;
        lvlsystem.SkillPoints -= Unlock09Req;
        TotalSpentSP += Unlock09Req;
        isAcquiredS09 = true;
    }

    public void UnlockSkill10()
    {
        eat.flatXpPerFood *= 1.2f;
        lvlsystem.SkillPoints -= Unlock10Req;
        TotalSpentSP += Unlock10Req;
        isAcquiredS10 = true;
    }

    public void UnlockSkill11()
    {
        eat.flatXpPerFood *= 1.4f;
        lvlsystem.SkillPoints -= Unlock11Req;
        TotalSpentSP += Unlock11Req;
        isAcquiredS11 = true;
    }

    public void UnlockSkill12()
    {
        eat.flatXpPerFood *= 1.6f;
        lvlsystem.SkillPoints -= Unlock12Req;
        TotalSpentSP += Unlock12Req;
        isAcquiredS12 = true;
    }
    
    public void UnlockSkill13()
    {
        lvlsystem.SkillPoints -= Unlock13Req;
        TotalSpentSP += Unlock13Req;
        isAcquiredS13 = true;
    }
    
}
