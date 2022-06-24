using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Item()
    {

    }

    public Item(string title, int cost, int weight, string additionalInfo = "")
    {
        Title = title;
        Cost = cost;
        Weight = weight;
        AdditionalInfo = additionalInfo;
    }

    string title;
    int cost;
    int weight;
    string additionalInfo;

    public string Title { get => title; set => title = value; }
    public int Cost { get => cost; set => cost = value; }
    public int Weight { get => weight; set => weight = value; }
    public string AdditionalInfo { get => additionalInfo; set => additionalInfo = value; }

}
