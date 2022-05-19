using System;
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

    public void SetRandomCharacterClass()
    {
        System.Random random = new System.Random();
        findController.characterClassDropDown.value = random.Next(1, findController.characterClassDropDown.options.Count);
        CharacterClassChanger();
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
        findController.textDataController.HealthInfoUpdate();
        findController.textDataController.ProficienciesAndLanguagesInfoUpdater();
    }
    private void SetCharacterClassDefault()
    {
        findController.character.healthDice = 0;
        findController.character.abilityMain = "";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>();
    }
    private void SetCharacterClassBarbarian()
    {
        findController.character.healthDice = 12;
        findController.character.abilityMain = "Strength";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = true;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = true;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Средний доспех",
            "Щит",
            "Простое оружие",
            "Воинское оружие"
        };
    }
    private void SetCharacterClassBard()
    {
        findController.character.healthDice = 8;
        findController.character.abilityMain = "Charisma";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = true;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = true;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Простое оружие",
            "Длинный меч",
            "Короткий меч",
            "Рапира",
            "Ручной арбалет"
        };
    }
    private void SetCharacterClassCleric()
    {
        findController.character.healthDice = 8;
        findController.character.abilityMain = "Wisdom";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = true;
        findController.abilityToggle["Charisma"].isOn = true;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Средний доспех",
            "Щит",
            "Простое оружие"
        };
    }
    private void SetCharacterClassDruid()
    {
        findController.character.healthDice = 8;
        findController.character.abilityMain = "Wisdom";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = true;
        findController.abilityToggle["Wisdom"].isOn = true;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Средний доспех",
            "Щит (не носит доспехи и щиты из металла)",
            "Боевой посох",
            "Булава",
            "Дротик",
            "Дубинка",
            "Кинжал",
            "Копье",
            "Метательное копье",
            "Праща",
            "Серп",
            "Скимитар"
        };
    }
    private void SetCharacterClassFighter()
    {
        findController.character.healthDice = 10;
        findController.character.abilityMain = "Strength";
        findController.character.abilityMainSecond = "Dexterity";
        findController.abilityToggle["Strength"].isOn = true;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = true;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Все доспехи",
            "Щит",
            "Простое оружие",
            "Воинское оружие"
        };
    }
    private void SetCharacterClassMonk()
    {
        findController.character.healthDice = 8;
        findController.character.abilityMain = "Dexterity";
        findController.character.abilityMainSecond = "Wisdom";
        findController.abilityToggle["Strength"].isOn = true;
        findController.abilityToggle["Dexterity"].isOn = true;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Простое оружие",
            "Короткий меч"
        };
    }
    private void SetCharacterClassPaladin()
    {
        findController.character.healthDice = 10;
        findController.character.abilityMain = "Strength";
        findController.character.abilityMainSecond = "Charisma";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = true;
        findController.abilityToggle["Charisma"].isOn = true;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Все доспехи",
            "Щит",
            "Простое оружие",
            "Воинское оружие"
        };
    }
    private void SetCharacterClassRanger()
    {
        findController.character.healthDice = 10;
        findController.character.abilityMain = "Charisma";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = true;
        findController.abilityToggle["Dexterity"].isOn = true;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Средний доспех",
            "Щит",
            "Простое оружие",
            "Воинское оружие"
        };
    }
    private void SetCharacterClassRogue()
    {
        findController.character.healthDice = 8;
        findController.character.abilityMain = "Dexterity";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = true;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = true;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Простое оружие",
            "Длинный меч",
            "Короткий меч",
            "Рапира",
            "Ручной арбалет"
        };
    }
    private void SetCharacterClassSorcerer()
    {
        findController.character.healthDice = 6;
        findController.character.abilityMain = "Charisma";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = true;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = false;
        findController.abilityToggle["Charisma"].isOn = true;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Боевой посох",
            "Дротик",
            "Кинжал",
            "Легкий арбалет",
            "Праща"
        };
    }
    private void SetCharacterClassWarlock()
    {
        findController.character.healthDice = 8;
        findController.character.abilityMain = "Charisma";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = false;
        findController.abilityToggle["Wisdom"].isOn = true;
        findController.abilityToggle["Charisma"].isOn = true;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Легкий доспех",
            "Простое оружие"
        };
    }
    private void SetCharacterClassWizard()
    {
        findController.character.healthDice = 6;
        findController.character.abilityMain = "Intelligence";
        findController.character.abilityMainSecond = "";
        findController.abilityToggle["Strength"].isOn = false;
        findController.abilityToggle["Dexterity"].isOn = false;
        findController.abilityToggle["Constitution"].isOn = false;
        findController.abilityToggle["Intelligence"].isOn = true;
        findController.abilityToggle["Wisdom"].isOn = true;
        findController.abilityToggle["Charisma"].isOn = false;

        findController.character.proficienciesCharacterClass = new List<string>
        {
            "Боевой посох",
            "Дротик",
            "Кинжал",
            "Легкий арбалет",
            "Праща"
        };
    }
}
