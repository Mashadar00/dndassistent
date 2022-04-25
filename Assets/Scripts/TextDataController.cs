using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDataController : MonoBehaviour
{
    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void FeaturesInfoUpdater()
    {
        findController.features.text = "";
        foreach (string feature in findController.character.featuresRace)
        {
            findController.features.text += feature + "\n";
        }
    } 
    public void ProficienciesAndLanguagesInfoUpdater()
    {
        findController.proficienciesAndLanguages.text = "”мени€: ";
        foreach (string prof in findController.character.proficienciesRace)
        {
            findController.proficienciesAndLanguages.text += prof + ", ";
        }
        findController.proficienciesAndLanguages.text += "\nязыки: ";
        foreach (string lang in findController.character.languagesRace)
        {
            findController.proficienciesAndLanguages.text += lang + ", ";
        }
    }

    public void SpeedInfoUpdate()
    {
        findController.speed.text = findController.character.speed.ToString();
    }
}
