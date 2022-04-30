using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameObjectFindController : MonoBehaviour
{
    public GameObject[] characterLists;
    public Button buttonPageLeft, buttonPageRight;
    public CharacterData character;
    public SkillsController skillsController;
    public AbilityController abilityController;
    public TextDataController textDataController;
    public ItemsController itemsController;
    public TMP_Text levelBonus, raceSelected, race, features, proficienciesAndLanguages, 
        speed, characterClassSelected, characterClass, healthDice, health, initiative, 
        passivePerception;
    public TMP_InputField level;
    public TMP_Dropdown raceDropDown, characterClassDropDown;
    public Dictionary<string, TMP_InputField> abilityInputField, abilityScoreField;
    public Dictionary<string, TMP_Text> abilityBonus;
    public Dictionary<string, Text> abilityToggleText;
    public Dictionary<string, Toggle> abilityToggle;
    public Dictionary<string, Text[]> skillToggleText;
    public Dictionary<string, Toggle[]> skillToggle;
    public Dictionary<string, GameObject> skills;

    void Awake()
    {
        characterLists = new GameObject[3];
        characterLists[0] = GameObject.Find("CharacterListFirst");
        characterLists[1] = GameObject.Find("CharacterListSecond");
        characterLists[1].SetActive(false);
        characterLists[2] = GameObject.Find("CharacterListThird");
        characterLists[2].SetActive(false);
        buttonPageLeft = GameObject.Find("ButtonPageLeft").GetComponent<Button>();
        buttonPageRight = GameObject.Find("ButtonPageRight").GetComponent<Button>();

        character = GameObject.Find("Character").GetComponent<CharacterData>();
        skillsController = GameObject.Find("Skills").GetComponent<SkillsController>();
        abilityController = GameObject.Find("Ability").GetComponent<AbilityController>();
        textDataController = GameObject.Find("Canvas").GetComponent<TextDataController>();
        itemsController = GameObject.Find("Canvas").GetComponent<ItemsController>();

        level = GameObject.Find("Level").GetComponent<TMP_InputField>();
        levelBonus = GameObject.Find("LevelBonus").GetComponent<TMP_Text>();
        speed = GameObject.Find("Speed").GetComponent<TMP_Text>();
        initiative = GameObject.Find("Initiative").GetComponent<TMP_Text>();
        healthDice = GameObject.Find("HealthDice").GetComponent<TMP_Text>();
        health = GameObject.Find("Health").GetComponent<TMP_Text>();
        passivePerception = GameObject.Find("PassivePerception").GetComponent<TMP_Text>();

        raceSelected = GameObject.Find("RaceChoice").GetComponentInChildren<TMP_Text>();
        race = GameObject.Find("Race").GetComponent<TMP_Text>();
        raceDropDown = GameObject.Find("RaceChoice").GetComponent<TMP_Dropdown>();
        characterClassSelected = GameObject.Find("CharacterClassChoice").GetComponentInChildren<TMP_Text>();
        characterClass = GameObject.Find("CharacterClass").GetComponent<TMP_Text>();
        characterClassDropDown = GameObject.Find("CharacterClassChoice").GetComponent<TMP_Dropdown>();

        features = GameObject.Find("Features").GetComponent<TMP_Text>();
        proficienciesAndLanguages = GameObject.Find("ProficienciesAndLanguages").GetComponent<TMP_Text>();


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

        skills = new();
        for (int i = 0; i < skillsController.skillArray.Length; i++)
        {
            skills.Add(skillsController.skillArray[i] + "Toggle", GameObject.Find(skillsController.skillArray[i] + "Toggle"));
        }
    }
}
