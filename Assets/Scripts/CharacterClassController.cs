﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterClassController : MonoBehaviour
{
    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void CharacterClassChanger()
    {
        string characterClassSelected = findController.characterClassSelected.text;
        findController.characterClass.text = characterClassSelected;
        SetCharacterClassToCharacter(characterClassSelected);
    }

    private void SetCharacterClassToCharacter(string characterClassSelected)
    {
        findController.character.characterClass = characterClassSelected;

        switch (characterClassSelected)
        {
            case "Class": SetCharacterClassDefault(); break;
            case "Варвар": SetCharacterClassBarbarian(); break;
            case "Бард": SetCharacterClassBard(); break;
            case "Жрец": SetCharacterClassCleric(); break;
            case "Друид": SetCharacterClassDruid(); break;
            case "Воин": SetCharacterClassFighter(); break;
            case "Монах": SetCharacterClassMonk(); break;
            case "Паладин": SetCharacterClassPaladin(); break;
            case "Следопыт": SetCharacterClassRanger(); break;
            case "Плут": SetCharacterClassRogue(); break;
            case "Чародей": SetCharacterClassSorcerer(); break;
            case "Колдун": SetCharacterClassWarlock(); break;
            case "Волшебник": SetCharacterClassWizard(); break;

            default:
                break;
        }

        findController.abilityController.AbilitySavingThrowsInfoUpdateAll();
        findController.textDataController.HealthDiceInfoUpdate();
        findController.textDataController.ProficienciesAndLanguagesInfoUpdater();
    }

    private void SetCharacterClassDefault()
    {
        findController.character.healthDice = 0;
        findController.character.abilityMain = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;

        findController.character.proficienciesCharacterClass = new();
    }

    private void SetCharacterClassBarbarian()
    {
        findController.character.healthDice = 12;
        findController.character.abilityMain = "Strength";
        findController.abilityToggle["Strength"].isOn = true;
        findController.abilityToggle["Constitution"].isOn = true;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкие доспехи",
            "Средние доспехи",
            "Щиты",
            "Простое оружие",
            "Воинское оружие"
        };
    }

    private void SetCharacterClassBard()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassCleric()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassDruid()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassFighter()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassMonk()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassPaladin()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassRanger()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassRogue()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassSorcerer()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassWarlock()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassWizard()
    {
        throw new NotImplementedException();
    }
}
