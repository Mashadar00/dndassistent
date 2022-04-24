using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AbilityController : MonoBehaviour
{

    public string[] abilityTitleArray = { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma" };

    //public void AbilityInputFieldChange(string abilityTitle)
    //{
    //    dataFields fields = GetFields(abilityTitle);

    //    int abilityScore = int.Parse(fields.fieldAbilityInput.text); 
    //    int abilityLevelBonus = int.Parse(fields.textBonusLevel.text);
    //    int abilityModifer;

    //    CharacterController character = GameObject.Find("Character").GetComponent<CharacterController>();
    //    character.SetAbilityBasic(abilityTitle, abilityScore);

    //    fields.fieldAbility.text = character.GetAbility(abilityTitle).ToString();

    //    if (abilityScore < 10 && abilityScore % 2 == 1)
    //    {
    //        abilityScore--;
    //    }
    //    abilityModifer = (abilityScore - 10) / 2;

    //    fields.textAbilityBonus.text = abilityModifer.ToString();

    //    if (fields.toggleAbility.isOn)
    //    {
    //        abilityModifer += abilityLevelBonus;

    //    }

    //    fields.textAbilityToggle.text = abilityModifer.ToString();
    //}

    public void AbilityInputFieldChange(string abilityTitle)
    {
        dataFields fields = GetFields(abilityTitle);

        int abilityScore = int.Parse(fields.fieldAbilityInput.text);
        int abilityLevelBonus = int.Parse(fields.textBonusLevel.text);
        int abilityModifer;

        CharacterController character = GameObject.Find("Character").GetComponent<CharacterController>();
        character.SetAbilityBasic(abilityTitle, int.Parse(fields.fieldAbilityInput.text));

        fields.fieldAbility.text = character.GetAbility(abilityTitle).ToString();

        if (abilityScore < 10 && abilityScore % 2 == 1)
        {
            abilityScore--;
        }
        abilityModifer = (abilityScore - 10) / 2;

        fields.textAbilityBonus.text = abilityModifer.ToString();

        if (fields.toggleAbility.isOn)
        {
            abilityModifer += abilityLevelBonus;

        }

        fields.textAbilityToggle.text = abilityModifer.ToString();
    }

    private struct dataFields
    {
        public TMP_Text textAbilityBonus;
        public Text textAbilityToggle;
        public TMP_InputField fieldAbilityInput;
        public Toggle toggleAbility;
        public TMP_Text textBonusLevel;
        public TMP_InputField fieldAbility; 
    }

    private dataFields GetFields(string abilityTitle)
    {
        return new dataFields()
        {
            textAbilityBonus = GameObject.Find(abilityTitle + "Bonus").GetComponent<TMP_Text>(),
            textAbilityToggle = GameObject.Find(abilityTitle + "Toggle").GetComponentInChildren<Text>(),
            fieldAbilityInput = GameObject.Find(abilityTitle + "InputField").GetComponent<TMP_InputField>(),
            toggleAbility = GameObject.Find(abilityTitle + "Toggle").GetComponent<Toggle>(),
            textBonusLevel = GameObject.Find("LevelBonus").GetComponent<TMP_Text>(),
            fieldAbility = GameObject.Find(abilityTitle).GetComponent<TMP_InputField>()
        };
    }

    public void CheckValidation(TMP_InputField ability)
    {
        ability.text = Mathf.Clamp(int.Parse(ability.text), 0, 30).ToString();
    }

    public void RandomizeAbility()
    {
        SkillsController skillsController = new();
        System.Random random = new();

        foreach (string abilityTitle in abilityTitleArray)
        {
            UnityEngine.Debug.Log(abilityTitle + "InputField");

            TMP_InputField fieldAbility = GameObject.Find(abilityTitle + "InputField").GetComponent<TMP_InputField>();
            fieldAbility.text = random.Next(21).ToString();

            AbilityInputFieldChange(abilityTitle);
            skillsController.SkillsModiferUpdater(abilityTitle);
        }
    }
}
