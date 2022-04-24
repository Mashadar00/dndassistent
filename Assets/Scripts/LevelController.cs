using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public void LevelCheckValidation()
    {
        TMP_InputField level = GameObject.Find("Level").GetComponent<TMP_InputField>();
        level.text = Mathf.Clamp(int.Parse(level.text), 0, 20).ToString();
    }

    public void LevelBonusUpdater()
    {
        int level = int.Parse(GameObject.Find("Level").GetComponent<TMP_InputField>().text);
        TMP_Text levelBonus = GameObject.Find("LevelBonus").GetComponent<TMP_Text>();
        if (level < 5)
        {
            levelBonus.text = "2";
        }
        else if (level < 9)
        {
            levelBonus.text = "3";
        }
        else if (level < 13)
        {
            levelBonus.text = "4";
        }
        else if (level < 17)
        {
            levelBonus.text = "5";
        }
        else
        {
            levelBonus.text = "6";
        }
    }
}
