using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Race : ScriptableObject
{
    [SerializeField]
    private string title;
    [SerializeField]
    private int strengthBonus;
    [SerializeField] 
    private int dexterityBonus;
    [SerializeField] 
    private int constitutionBonus;
    [SerializeField] 
    private int intelligenceBonus;
    [SerializeField] 
    private int wisdomBonus;
    [SerializeField] 
    private int charismaBonus;
    [SerializeField] 
    private int speed;
    [SerializeField] 
    private string skillProficienciy;
    [SerializeField] 
    private List<string> languages;
    [SerializeField] 
    private List<string> proficiencies;
    [SerializeField] 
    private List<string> features;

    public Race()
    {
        Title = "";
        StrengthBonus = 0;
        DexterityBonus = 0;
        ConstitutionBonus = 0;
        IntelligenceBonus = 0;
        WisdomBonus = 0;
        CharismaBonus = 0;
        Speed = 0;
        SkillProficienciy = "";
        Languages = new List<string>();
        Proficiencies = new List<string>();
        Features = new List<string>();
    }

    public Race(string title, int strengthBonus, int dexterityBonus, int constitutionBonus, int intelligenceBonus, int wisdomBonus, int charismaBonus, int speed, string skillProficienciy, List<string> languages, List<string> proficiencies, List<string> features)
    {
        Title = title;
        StrengthBonus = strengthBonus;
        DexterityBonus = dexterityBonus;
        ConstitutionBonus = constitutionBonus;
        IntelligenceBonus = intelligenceBonus;
        WisdomBonus = wisdomBonus;
        CharismaBonus = charismaBonus;
        Speed = speed;
        SkillProficienciy = skillProficienciy;
        Languages = languages;
        Proficiencies = proficiencies;
        Features = features;
    }

    public string Title { get => title; set => title = value; }
    public int StrengthBonus { get => strengthBonus; set => strengthBonus = value; }
    public int DexterityBonus { get => dexterityBonus; set => dexterityBonus = value; }
    public int ConstitutionBonus { get => constitutionBonus; set => constitutionBonus = value; }
    public int IntelligenceBonus { get => intelligenceBonus; set => intelligenceBonus = value; }
    public int WisdomBonus { get => wisdomBonus; set => wisdomBonus = value; }
    public int CharismaBonus { get => charismaBonus; set => charismaBonus = value; }
    public int Speed { get => speed; set => speed = value; }
    public string SkillProficienciy { get => skillProficienciy; set => skillProficienciy = value; }
    public List<string> Languages { get => languages; set => languages = value; }
    public List<string> Proficiencies { get => proficiencies; set => proficiencies = value; }
    public List<string> Features { get => features; set => features = value; }
}
