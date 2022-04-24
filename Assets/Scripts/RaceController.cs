using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaceController : MonoBehaviour
{
    public void RaceChanger()
    {
        string raceSelected = GameObject.Find("RaceChoice").GetComponentInChildren<TMP_Text>().text;

        TMP_Text race = GameObject.Find("Race").GetComponent<TMP_Text>();
        race.text = raceSelected;
        CharacterData character = GameObject.Find("Character").GetComponent<CharacterData>();


        SetRaceToCharacter(character, raceSelected);

        AbilityController abilityController = GameObject.Find("Ability").GetComponent<AbilityController>();
        SkillsController skillsController = GameObject.Find("Skills").GetComponent<SkillsController>();
        foreach (string abilityTitle in abilityController.abilityTitleArray)
        {
            abilityController.AbilityUpdateInfo(abilityTitle);
            skillsController.SkillsModiferUpdater(abilityTitle);
        }

        TMP_Text features = GameObject.Find("Features").GetComponent<TMP_Text>();
        features.text = "";
        foreach (string feature in character.featuresRace)
        {
            features.text += feature + "\n";
        }

        TMP_Text proficienciesAndLanguages = GameObject.Find("ProficienciesAndLanguages").GetComponent<TMP_Text>();
        proficienciesAndLanguages.text = "Умения: ";
        foreach (string prof in character.proficienciesRace)
        {
            proficienciesAndLanguages.text += prof + ", ";
        }
        proficienciesAndLanguages.text += "\nЯзыки: ";
        foreach (string lang in character.languagesRace)
        {
            proficienciesAndLanguages.text += lang + ", ";
        }
    }

    private void SetRaceToCharacter(CharacterData character, string raceSelected)
    {
        character.race = raceSelected;

        switch (raceSelected)
        {
            case "Race": SetRaceDefault(character); break;
            case "Горный Дварф": SetRaceMountainDvarf(character); break;

            default:
                break;
        }
    }

    private void SetRaceDefault(CharacterData character)
    {
        character.strengthRace = 0;
        character.dexterityRace = 0;
        character.constitutionRace = 0;
        character.intelligenceRace = 0;
        character.wisdomRace = 0;
        character.charismaRace = 0;

        character.speed = 0;

        character.languagesRace = new List<string>();
        character.proficienciesRace = new List<string>();
        character.featuresRace = new List<string>();
    }
    private void SetRaceMountainDvarf(CharacterData character)
    {
        character.strengthRace = 2;
        character.dexterityRace = 0;
        character.constitutionRace = 2;
        character.intelligenceRace = 0;
        character.wisdomRace = 0;
        character.charismaRace = 0;

        character.speed = 25;

        character.languagesRace = new List<string>
        {
            "Общий",
            "Дварфский"
        };
        character.proficienciesRace = new List<string>
        {
            "Легкие доспехи",
            "Средние доспехи",
            "Боевые топоры",
            "Ручные топоры",
            "Легкие молоты",
            "Боевые молоты",
            "Ручные топоры"
        };
        character.featuresRace = new List<string>
        {
            "Темное зрение 60",

            "Дварфская устойчивость. \n Вы совершаете с " +
            "преимуществом спасброски от яда и вы получаете " +
            "сопротивление к урону ядом",
            
            "Знание камня. \n Если вы совершаете проверку " +
            "Интеллекта (История), связанную с происхождением" +
            " работы по камню, вы считаетесь владеющим " +
            "навыком История, и добавляете к проверке удвоенный" +
            " бонус мастерства вместо обычного.",
        };
    }
}
