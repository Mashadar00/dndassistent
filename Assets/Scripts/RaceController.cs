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

        SetRaceToCharacter(raceSelected);

        AbilityController abilityController = new();
        SkillsController skillsController = new();
        foreach (string abilityTitle in abilityController.abilityTitleArray)
        {
            abilityController.AbilityUpdateInfo(abilityTitle);
            skillsController.SkillsModiferUpdater(abilityTitle);
        }
    }

    private void SetRaceToCharacter(string raceSelected)
    {
        CharacterController character = GameObject.Find("Character").GetComponent<CharacterController>();
        character.race = raceSelected;

        switch (raceSelected)
        {
            case "Race": SetRaceDefault(character); break;
            case "Горный Дварф": SetRaceMountainDvarf(character); break;

            default:
                break;
        }
    }

    private void SetRaceDefault(CharacterController character)
    {
        character.strengthRace = 0;
        character.dexterityRace = 0;
        character.constitutionRace = 0;
        character.intelligenceRace = 0;
        character.wisdomRace = 0;
        character.charismaRace = 0;

        character.speed = 0;

        character.languagesRace = new List<string>();
        character.proficienciesRase = new List<string>();
        character.featuresRace = new List<string>();
    }
    private void SetRaceMountainDvarf(CharacterController character)
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
        character.proficienciesRase = new List<string>
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
            
            "Знание камня. \n Если вы совершаете проверку" +
            "Интеллекта (История), связанную с происхождением" +
            " работы по камню, вы считаетесь владеющим " +
            "навыком История, и добавляете к проверке удвоенный" +
            " бонус мастерства вместо обычного.",
        };
    }
}
