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

        StringBuilder stringBuilder = new StringBuilder("");
        findController.features.text = "";
        foreach (string ftr in features)
        {
            stringBuilder.Append(ftr + "\n");
        }
        findController.features.text = stringBuilder.ToString();
    } 
    public void ProficienciesAndLanguagesInfoUpdater()
    {
        List<string> proficiencies = new List<string>();
        proficiencies.AddRange(findController.character.proficienciesRace);
        foreach (string prof in findController.character.proficienciesCharacterClass)
        {
            if (!proficiencies.Contains(prof))
            {
                proficiencies.Add(prof);
            }
        }

        if (proficiencies.Contains("Простое оружие"))
        {
            foreach (string prof in findController.itemsController.simpleWeapon)
            {
                if (proficiencies.Contains(prof))
                {
                    proficiencies.Remove(prof);
                }
            }
        }

        if (proficiencies.Contains("Воинское оружие"))
        {
            foreach (string prof in findController.itemsController.matrialWeapon)
            {
                if (proficiencies.Contains(prof))
                {
                    proficiencies.Remove(prof);
                }
            }
        }

        if (proficiencies.Contains("Все доспехи"))
        {
            foreach (string prof in findController.itemsController.armorClass)
            {
                if (proficiencies.Contains(prof))
                {
                    proficiencies.Remove(prof);
                }
            }
        }

        StringBuilder stringBuilder = new StringBuilder("Умения: ");
        foreach (string prof in proficiencies)
        {
            stringBuilder.Append(prof + ", ");
        }
        stringBuilder.Append("\nЯзыки: ");
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
    public void HealthInfoUpdate()
    {
        findController.health.text = (findController.character.healthDice + 
                                      findController.abilityController.AbilityBonusCalculation(findController.character.GetConstitution)).ToString();

        findController.healthDice.text = findController.character.level.ToString() + "d" + 
                                         findController.character.healthDice.ToString();
    }
    public void IninitiativeInfoUpdate()
    {
        findController.initiative.text = findController.abilityBonus["Dexterity"].text;
    }
    public void PassivePerceptionInfoUpdate()
    {
        findController.passivePerception.text = findController.character.passivePerception.ToString();
    }
}
