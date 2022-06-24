using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    public Weapon()
    {

    }

    public Weapon(string title, int cost, int damageMultiply, int damageScore, string damageType, int weight, string additionalInfo = "", bool isRange = false, bool isFencing = false)
    {
        Title = title;
        Cost = cost;
        DamageMultiply = damageMultiply;
        DamageScore = damageScore;
        DamageType = damageType;
        Weight = weight;
        AdditionalInfo = additionalInfo;
        IsRange = isRange;
        IsFencing = isFencing;
    }


    int damageMultiply;
    int damageScore;
    string damageType;
    bool isRange;
    bool isFencing;

    public int DamageMultiply { get => damageMultiply; set => damageMultiply = value; }
    public int DamageScore { get => damageScore; set => damageScore = value; }
    public string DamageType { get => damageType; set => damageType = value; }
    public bool IsRange { get => isRange; set => isRange = value; }
    public bool IsFencing { get => isFencing; set => isFencing = value; }
}
