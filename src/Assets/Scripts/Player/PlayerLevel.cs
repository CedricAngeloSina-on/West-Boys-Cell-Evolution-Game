using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerLevel : MonoBehaviour
{
    PlayerStats stats;

    public int level;
    public float currentXP;
    public float requiredXP;
    public int SkillPoints;

    private float lerpTimer;
    private float delayTimer;

    [Header("UI")]
    public Image frontXPbar;
    public Image backXPbar;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI xpText;

    [Header("Multipliers")]
    [Range(1f,300f)] 
    public float additionMultiplier = 300;
    [Range(2f,2f)]
    public float powerMultiplier = 2f;
    [Range(7f,14f)]
    public float divisionMultiplier = 7f;

    [Header("Autotroph")]
    public float ExpGain;
    public int TimeElapsed = 0;
    public int TimeDelay = 500;
    
    void Awake()
    {
        stats = GetComponent<PlayerStats>();
    }

    // Start is called before the first frame update
    void Start()
    {
        frontXPbar.fillAmount = currentXP / requiredXP;
        backXPbar.fillAmount = currentXP / requiredXP;
        requiredXP = CalculateRequiredXP();
        levelText.text = level.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateXpUI();
        if (currentXP > requiredXP)
        {
            LevelUp();
        }
        
        if (stats.Autotrophic == true)
        {
            if (TimeElapsed < TimeDelay)
            {
                TimeElapsed++;
            }
            else
            {
                GainExperienceFlatRate(ExpGain);
                TimeElapsed = 0;
            }
        }
    }

    public void UpdateXpUI()
    {
        float xpfraction = currentXP / requiredXP;
        float FXP = frontXPbar.fillAmount;
        if (FXP < xpfraction)
        {
            delayTimer += Time.deltaTime;
            frontXPbar.fillAmount = xpfraction;
            if (delayTimer > 3)
            {
                lerpTimer += Time.deltaTime;
                float percentComplete = lerpTimer / 1;
                frontXPbar.fillAmount = Mathf.Lerp(FXP, backXPbar.fillAmount, percentComplete);
            }
        }
        xpText.text = currentXP + "/" + requiredXP;
    }

    public void GainExperienceFlatRate(float xpGained)
    {
        currentXP += xpGained;
        lerpTimer = 0f;
        delayTimer = 0f;
    }

    public void GainedExperienceScalable(float xpGained, int passedLevel)
    {
        if (passedLevel < level)
        {
            float multiplier = 1 + (level - passedLevel) * 0.1f;
            currentXP += xpGained * multiplier;
        }
        else
        {
            currentXP += xpGained;
        }
        lerpTimer = 0f;
        delayTimer = 0f;
    }

    public void LevelUp()
    {
        level++;
        SkillPoints += 2;
        frontXPbar.fillAmount = 0f;
        backXPbar.fillAmount = 0f;
        currentXP = Mathf.RoundToInt(currentXP - requiredXP);
        GetComponent<PlayerHealth>().IncreaseHealth(level);
        requiredXP = CalculateRequiredXP();
        levelText.text = level.ToString();
    }

    private int CalculateRequiredXP()
    {
        int solveForRequiredXP = 0;
        for (int levelCycle = 1; levelCycle <= level; levelCycle++)
        {
            solveForRequiredXP += (int)Mathf.Floor(levelCycle + additionMultiplier * Mathf.Pow(powerMultiplier, levelCycle / divisionMultiplier));
        }
        return solveForRequiredXP / 4;
    }
}
