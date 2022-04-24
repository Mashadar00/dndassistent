using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillsController : MonoBehaviour
{
    public void SkillsModiferUpdater(string abilityTitle)
    {
        int levelBonus = int.Parse(GameObject.Find("LevelBonus").GetComponent<TMP_Text>().text);
        int abilityBonus = int.Parse(GameObject.Find(abilityTitle + "Bonus").GetComponent<TMP_Text>().text);

        switch (abilityTitle)
        {
            case "Strength":
                dataFieldsStrength fieldsStrength = GetFieldsStrength();
                SkillModiferChange(levelBonus, abilityBonus, fieldsStrength.textAthleticsToggle);
                break;

            case "Dexterity":
                dataFieldsDexterity fieldsDexterity = GetFieldsDexterity();
                SkillModiferChange(levelBonus, abilityBonus, fieldsDexterity.textAcrobaticsToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsDexterity.textSleightOfHandToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsDexterity.textStealthToggle);
                break;

            case "Intelligence":
                dataFieldsIntelligence fieldsIntelligence = GetFieldsIntelligence();
                SkillModiferChange(levelBonus, abilityBonus, fieldsIntelligence.textHistoryToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsIntelligence.textArcanaToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsIntelligence.textNatureToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsIntelligence.textInvestigationToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsIntelligence.textReligionToggle);
                break;

            case "Wisdom":
                dataFieldsWisdom fieldsWisdom = GetFieldsWisdom();
                SkillModiferChange(levelBonus, abilityBonus, fieldsWisdom.textPerceptioToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsWisdom.textSurvivalToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsWisdom.textMedicineToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsWisdom.textInsightToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsWisdom.textAnimalHandlingToggle);
                break;

            case "Charisma":
                dataFieldsCharisma fieldsCharisma = GetFieldsCharisma();
                SkillModiferChange(levelBonus, abilityBonus, fieldsCharisma.textStrengthIntimidationToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsCharisma.textDeceptionToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsCharisma.textPerfomanceToggle);
                SkillModiferChange(levelBonus, abilityBonus, fieldsCharisma.textPersuasionToggle);
                break;

            default:
                break;
        }
    }

    public void SkillOnToggleUpdate(string skillTitle)
    {       
        GameObject skill = GameObject.Find(skillTitle);
        
        int skillBonus = int.Parse(skill.GetComponentInChildren<Text>().text);
        int levelBonus = int.Parse(GameObject.Find("LevelBonus").GetComponent<TMP_Text>().text);

        if (skill.GetComponent<Toggle>().isOn)
        {
            skillBonus += levelBonus;
        }
        else
        {
            skillBonus -= levelBonus;
        }
        skill.GetComponentInChildren<Text>().text = skillBonus.ToString();
    }

    private void SkillModiferChange(int levelBonus, int abilityBonus, GameObject skill)
    {
        int skillBonus = abilityBonus;
        if (skill.GetComponent<Toggle>().isOn)
        {
            skillBonus += levelBonus; 
        }
        skill.GetComponentInChildren<Text>().text = skillBonus.ToString();
    }

    private struct dataFieldsStrength
    {
        public GameObject textAthleticsToggle;
  
    }
    private dataFieldsStrength GetFieldsStrength()
    {
        return new dataFieldsStrength()
        {
            textAthleticsToggle = GameObject.Find("AthleticsStrToggle")
        };
    }

    private struct dataFieldsDexterity
    {
        public GameObject textAcrobaticsToggle;
        public GameObject textSleightOfHandToggle;
        public GameObject textStealthToggle;

    }
    private dataFieldsDexterity GetFieldsDexterity()
    {
        return new dataFieldsDexterity()
        {
            textAcrobaticsToggle = GameObject.Find("AcrobaticsDexToggle"),
            textSleightOfHandToggle = GameObject.Find("SleightOfHandDexToggle"),
            textStealthToggle = GameObject.Find("StealthDexToggle")
        };
    }

    private struct dataFieldsIntelligence
    {
        public GameObject textHistoryToggle;
        public GameObject textArcanaToggle;
        public GameObject textNatureToggle;
        public GameObject textInvestigationToggle;
        public GameObject textReligionToggle;

    }
    private dataFieldsIntelligence GetFieldsIntelligence()
    {
        return new dataFieldsIntelligence()
        {
            textHistoryToggle = GameObject.Find("HistoryIntToggle"),
            textArcanaToggle = GameObject.Find("ArcanaIntToggle"),
            textNatureToggle = GameObject.Find("NatureIntToggle"),
            textInvestigationToggle = GameObject.Find("InvestigationIntToggle"),
            textReligionToggle = GameObject.Find("ReligionIntToggle")
        };
    }

    private struct dataFieldsWisdom
    {
        public GameObject textPerceptioToggle;
        public GameObject textSurvivalToggle;
        public GameObject textMedicineToggle;
        public GameObject textInsightToggle;
        public GameObject textAnimalHandlingToggle;

    }
    private dataFieldsWisdom GetFieldsWisdom()
    {
        return new dataFieldsWisdom()
        {
            textPerceptioToggle = GameObject.Find("PerceptionWisToggle"),
            textSurvivalToggle = GameObject.Find("SurvivalWisToggle"),
            textMedicineToggle = GameObject.Find("MedicineWisToggle"),
            textInsightToggle = GameObject.Find("InsightWisToggle"),
            textAnimalHandlingToggle = GameObject.Find("AnimalHandlingWisToggle")
        };
    }

    private struct dataFieldsCharisma
    {
        public GameObject textStrengthIntimidationToggle;
        public GameObject textDeceptionToggle;
        public GameObject textPerfomanceToggle;
        public GameObject textPersuasionToggle;
    }
    private dataFieldsCharisma GetFieldsCharisma()
    {
        return new dataFieldsCharisma()
        {
            textStrengthIntimidationToggle = GameObject.Find("StrengthIntimidationChaToggle"),
            textDeceptionToggle = GameObject.Find("DeceptionChaToggle"),
            textPerfomanceToggle = GameObject.Find("PerfomanceChaToggle"),
            textPersuasionToggle = GameObject.Find("PersuasionChaToggle")
        };
    }
}
