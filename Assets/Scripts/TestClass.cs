using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestClass : MonoBehaviour
{
    public TMP_Text q, w, e, r, t, y;

    public void CharacterAbility()
    {
        CharacterData character = GameObject.Find("Character").GetComponent<CharacterData>();
        q.text = character.GetStrength.ToString();
        w.text = character.GetIntelligence.ToString();
        e.text = character.GetConstitution.ToString();
        r.text = character.GetDexterity.ToString();     
        t.text = character.GetWisdom.ToString();
        y.text = character.GetCharisma.ToString();
    }
}
