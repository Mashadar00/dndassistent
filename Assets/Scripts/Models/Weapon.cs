using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Weapon()
    {

    }

    public Weapon(string title, int cost, int weight, int damageMultiply, int damageScore, string damageType, string additionalInfo = "")
    {
        Title = title;
        Cost = cost;
        DamageMultiply = damageMultiply;
        DamageScore = damageScore;
        DamageType = damageType;
        Weight = weight;
        AdditionalInfo = additionalInfo;
    }

    string title;
    int cost;
    int damageMultiply;
    int damageScore;
    string damageType;
    int weight;
    string additionalInfo;

    public string Title { get => title; set => title = value; }
    public int Cost { get => cost; set => cost = value; }
    public int Weight { get => weight; set => weight = value; }
    public int DamageMultiply { get => damageMultiply; set => damageMultiply = value; }
    public int DamageScore { get => damageScore; set => damageScore = value; }
    public string DamageType { get => damageType; set => damageType = value; }
    public string AdditionalInfo { get => additionalInfo; set => additionalInfo = value; }

}
