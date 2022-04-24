using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RaceController : MonoBehaviour
{
    public void RaceChanger()
    {
        TMP_Text raceSelected = GameObject.Find("RaceChoice").GetComponentInChildren<TMP_Text>();

        TMP_Text race = GameObject.Find("Race").GetComponent<TMP_Text>();
        race.text = raceSelected.text;

        CharacterController character = GameObject.Find("Character").GetComponent<CharacterController>();
        character.race = raceSelected.text;

        if (raceSelected.text == "Race")
        {
            character.strengthRace = 0;
            character.dexterityRace = 0;
            character.constitutionRace = 0;
            character.intelligenceRace = 0;
            character.wisdomRace = 0;
            character.charismaRace = 0;

            character.speed = 0;
        }
        else if (raceSelected.text == "Горный Дварф")
        {
            character.strengthRace = 2;
            character.dexterityRace = 0;
            character.constitutionRace = 2;
            character.intelligenceRace = 0;
            character.wisdomRace = 0;
            character.charismaRace = 0;

            character.speed = 25;
        }
    }
}
