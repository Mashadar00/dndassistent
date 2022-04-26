using System.Collections;
using System.Collections.Generic;
using System.Text;
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
        List<string> features = findController.character.featuresRace;

        StringBuilder stringBuilder = new("");
        findController.features.text = "";
        foreach (string ftr in features)
        {
            stringBuilder.Append(ftr + "\n");
        }
        findController.features.text = stringBuilder.ToString();
    } 
    public void ProficienciesAndLanguagesInfoUpdater()
    {
        List<string> proficiencies = findController.character.proficienciesRace;
        foreach (string prof in findController.character.proficienciesCharacterClass)
        {
            if (!proficiencies.Contains(prof))
            {
                proficiencies.Add(prof);
            }
        }

        if (proficiencies.Contains("������� ������"))
        {
            foreach (string prof in findController.itemsController.simpleWeapon)
            {
                if (proficiencies.Contains(prof))
                {
                    proficiencies.Remove(prof);
                }
            }
        }

        if (proficiencies.Contains("�������� ������"))
        {
            foreach (string prof in findController.itemsController.matrialWeapon)
            {
                if (proficiencies.Contains(prof))
                {
                    proficiencies.Remove(prof);
                }
            }
        }

        StringBuilder stringBuilder = new("������: ");
        foreach (string prof in proficiencies)
        {
            stringBuilder.Append(prof + ", ");
        }
        stringBuilder.Append("\n�����: ");
        foreach (string lang in findController.character.languagesRace)
        {
            stringBuilder.Append(lang + ", ");
        }

        findController.proficienciesAndLanguages.text = stringBuilder.ToString();
    }

    public void SpeedInfoUpdate()
    {
        findController.speed.text = findController.character.speed.ToString();
    }

    public void HealthDiceInfoUpdate()
    {
        findController.healthDice.text = findController.character.healthDice.ToString();
    }
}
