using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SkillsController : MonoBehaviour
{
    public string[] skillArray = { "AthleticsStr" , "AcrobaticsDex", "SleightOfHandDex", "StealthDex" , "HistoryInt", "ArcanaInt", "NatureInt", "InvestigationInt", "ReligionInt" ,
    "PerceptionWis", "SurvivalWis", "MedicineWis", "InsightWis", "AnimalHandlingWis", "StrengthIntimidationCha", "DeceptionCha", "PerfomanceCha", "PersuasionCha"};

    public Dictionary<string, string[]> skillDictionary = new Dictionary<string, string[]>()
    {
        {"Strength", new string[] {"AthleticsStr"} },
        {"Dexterity", new string[] { "AcrobaticsDex", "SleightOfHandDex", "StealthDex" } },
        {"Constitution", new string[] { } },
        {"Intelligence", new string[] { "HistoryInt", "ArcanaInt", "NatureInt", "InvestigationInt", "ReligionInt" } },
        {"Wisdom", new string[] { "PerceptionWis", "SurvivalWis", "MedicineWis", "InsightWis", "AnimalHandlingWis" } },
        {"Charisma", new string[] { "StrengthIntimidationCha", "DeceptionCha", "PerfomanceCha", "PersuasionCha" } }
    };

    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();

    }

    public void SkillsModiferUpdater(string abilityTitle)
    {
        int skillBonus = int.Parse(findController.abilityBonus[abilityTitle].text);

        for (int i = 0; i < findController.skillToggleText[abilityTitle].Length; i++)
        {
            if (findController.skillToggle[abilityTitle][i].isOn)
            {
                skillBonus += int.Parse(findController.levelBonus.text);
            }
            findController.skillToggleText[abilityTitle][i].text = skillBonus.ToString();
        }

        if (abilityTitle == "Wisdom")
        {
            findController.character.SetPassivePerception(skillBonus);
            findController.textDataController.PassivePerceptionInfoUpdate();
        }
    }

    //public void SkillOnToggleUpdate(string skillTitle)
    //{
    //    GameObject skill = findController.skills[skillTitle];

    //    int skillBonus = int.Parse(skill.GetComponentInChildren<Text>().text);
    //    int levelBonus = int.Parse(findController.levelBonus.text);

    //    if (skill.GetComponent<Toggle>().isOn)
    //    {
    //        skillBonus += levelBonus;
    //    }
    //    else
    //    {
    //        skillBonus -= levelBonus;
    //    }
    //    skill.GetComponentInChildren<Text>().text = skillBonus.ToString();
    //}
}
