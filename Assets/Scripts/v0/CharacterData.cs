using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData : MonoBehaviour
{
    public int strengthBasic, dexterityBasic, constitutionBasic, intelligenceBasic, wisdomBasic, charismaBasic;
    public int strengthRace, dexterityRace, constitutionRace, intelligenceRace, wisdomRace, charismaRace;

    public int level, speed, healthDice, health, initiative, passivePerception;
    public string race, characterClass, abilityMain, abilityMainSecond;

    public List<string> proficienciesRace, proficienciesCharacterClass, languagesRace, featuresRace;
    public List<Weapon> weapons;


    private void Start()
    {
        CharacterInit();
    }
    private void CharacterInit()
    {
        strengthBasic = 10;
        dexterityBasic = 10;
        constitutionBasic = 10;
        intelligenceBasic = 10;
        wisdomBasic = 10;
        charismaBasic = 10;
        strengthRace = 0;
        dexterityRace = 0;
        constitutionRace = 0;
        intelligenceRace = 0;
        wisdomRace = 0;
        charismaRace = 0;

        level = 1;
        speed = 0;
        healthDice = 0;
        health = 0;
        initiative = 0;
        passivePerception = 10;

        race = "Race";
        characterClass = "Class";
        abilityMain = "";
        abilityMainSecond = "";

        proficienciesRace = new List<string>();
        proficienciesCharacterClass = new List<string>();
        languagesRace = new List<string>();
        featuresRace = new List<string>();
        weapons = new List<Weapon>();
    }

    public int GetStrength { get => strengthBasic + strengthRace; }
    public int GetDexterity { get => dexterityBasic + dexterityRace; }
    public int GetConstitution { get => constitutionBasic + constitutionRace; }
    public int GetIntelligence { get => intelligenceBasic + intelligenceRace; }
    public int GetWisdom { get => wisdomBasic + wisdomRace; }
    public int GetCharisma { get => charismaBasic + charismaRace; }

    public int GetAbility(string abilityTitle)
    {
        return abilityTitle switch
        {
            "Strength" => GetStrength,
            "Dexterity" => GetDexterity,
            "Constitution" => GetConstitution,
            "Intelligence" => GetIntelligence,
            "Wisdom" => GetWisdom,
            "Charisma" => GetCharisma,
            _ => 0,
        };
    }
    public int GetAbilityBasic(string abilityTitle)
    {
        return abilityTitle switch
        {
            "Strength" => strengthBasic,
            "Dexterity" => dexterityBasic,
            "Constitution" => constitutionBasic,
            "Intelligence" => intelligenceBasic,
            "Wisdom" => wisdomBasic,
            "Charisma" => charismaBasic,
            _ => 0,
        };
    }
    public void SetAbilityBasic(string abilityTitle, int abilityScore)
    {
        switch (abilityTitle)
        {
            case "Strength":
                strengthBasic = abilityScore;
                break;

            case "Dexterity":
                dexterityBasic = abilityScore;
                break;

            case "Constitution":
                constitutionBasic = abilityScore;
                break;

            case "Intelligence":
                intelligenceBasic = abilityScore;
                break;

            case "Wisdom":
                wisdomBasic = abilityScore;
                break;

            case "Charisma":
                charismaBasic = abilityScore;
                break;

            default:
                break;
        }
    }
    
    public void SetPassivePerception(int skillBonus)
    {
        passivePerception = 10 + skillBonus;
    }
}
