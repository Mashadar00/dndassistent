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

    private GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void AbilityInputFieldChange(string abilityTitle)
    {
        int abilityScore = int.Parse(findController.abilityInputField[abilityTitle].text);

        findController.character.SetAbilityBasic(abilityTitle, abilityScore);
        AbilityUpdateInfo(abilityTitle);
    }

    public void AbilityUpdateInfoAll()
    {
        foreach (string abilityTitle in abilityTitleArray)
        {
            AbilityUpdateInfo(abilityTitle);
        }
    }
    public void AbilityUpdateInfo(string abilityTitle)
    {
        int abilityScore = findController.character.GetAbility(abilityTitle);

        if (abilityScore > 20)
        {
            abilityScore = 20;
        }

        findController.abilityScoreField[abilityTitle].text = abilityScore.ToString();

        abilityScore = AbilityBonusCalculation(abilityScore);
        findController.abilityBonus[abilityTitle].text = abilityScore.ToString();
        
        AbilitySavingThrowsInfoUpdate(abilityTitle);
        findController.skillsController.SkillsModiferUpdater(abilityTitle);

        if (abilityTitle == "Dexterity")
        {
            findController.textDataController.IninitiativeInfoUpdate();
        }
    }

    public int AbilityBonusCalculation(int abilityScore)
    {
        if (abilityScore < 10 && abilityScore % 2 == 1)
        {
            abilityScore--;
        }
        return (abilityScore - 10) / 2;
    }

    public void AbilitySavingThrowsInfoUpdateAll()
    {
        foreach (string abilityTitle in abilityTitleArray)
        {
            AbilitySavingThrowsInfoUpdate(abilityTitle);
        }
    }
    public void AbilitySavingThrowsInfoUpdate(string abilityTitle)
    {
        int abilityScore = findController.character.GetAbility(abilityTitle);
        abilityScore = AbilityBonusCalculation(abilityScore);

        if (findController.abilityToggle[abilityTitle].isOn)
        {
            abilityScore += int.Parse(findController.levelBonus.text);
        }
        findController.abilityToggleText[abilityTitle].text = abilityScore.ToString();
    }
    public void CheckValidation(TMP_InputField ability)
    {
        ability.text = Mathf.Clamp(int.Parse(ability.text), 0, 20).ToString();
    }

    public void RandomizeAbility()
    {
        System.Random random = new System.Random();

        foreach (string abilityTitle in abilityTitleArray)
        {
            findController.character.SetAbilityBasic(abilityTitle, random.Next(21));

            findController.abilityInputField[abilityTitle].text = findController.character.GetAbilityBasic(abilityTitle).ToString();

            AbilityUpdateInfo(abilityTitle);
            findController.skillsController.SkillsModiferUpdater(abilityTitle);
        }
    }
}
