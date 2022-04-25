using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectFindController : MonoBehaviour
{
    public CharacterData character;
    public SkillsController skillsController;
    public AbilityController abilityController;
    public TMP_Text levelBonus;
    public Dictionary<string, TMP_InputField> abilityInputField, abilityScoreField;
    public Dictionary<string, TMP_Text> abilityBonus;
    public Dictionary<string, Text> abilityToggleText;
    public Dictionary<string, Toggle> abilityToggle;
    public Dictionary<string, Text[]> skillToggleText;
    public Dictionary<string, Toggle[]> skillToggle;

    void Start()
    {
        character = GameObject.Find("Character").GetComponent<CharacterData>();
        levelBonus = GameObject.Find("LevelBonus").GetComponent<TMP_Text>();
        skillsController = GameObject.Find("Skills").GetComponent<SkillsController>();
        abilityController = GameObject.Find("Ability").GetComponent<AbilityController>();

        abilityInputField = new();
        abilityScoreField = new();
        abilityBonus = new();
        abilityToggleText = new();
        abilityToggle = new();
        skillToggleText = new();
        skillToggle = new();

        foreach (string abilityTitle in abilityController.abilityTitleArray)
        {
            abilityInputField.Add(abilityTitle, GameObject.Find(abilityTitle + "InputField").GetComponent<TMP_InputField>());
            abilityScoreField.Add(abilityTitle, GameObject.Find(abilityTitle).GetComponent<TMP_InputField>());
            abilityToggle.Add(abilityTitle, GameObject.Find(abilityTitle + "Toggle").GetComponent<Toggle>());
            abilityToggleText.Add(abilityTitle, GameObject.Find(abilityTitle + "Toggle").GetComponentInChildren<Text>());
            abilityBonus.Add(abilityTitle, GameObject.Find(abilityTitle + "Bonus").GetComponent<TMP_Text>());

            Text[] tempText = new Text[skillsController.skillDictionary[abilityTitle].Length];
            Toggle[] tempToggle = new Toggle[skillsController.skillDictionary[abilityTitle].Length];
            for (int i = 0; i < skillsController.skillDictionary[abilityTitle].Length; i++)
            {
                tempText[i] = GameObject.Find(skillsController.skillDictionary[abilityTitle][i] + "Toggle").GetComponentInChildren<Text>();
                tempToggle[i] = GameObject.Find(skillsController.skillDictionary[abilityTitle][i] + "Toggle").GetComponent<Toggle>();
            }
            skillToggle.Add(abilityTitle, tempToggle);
            skillToggleText.Add(abilityTitle, tempText);
        }
    }
}
