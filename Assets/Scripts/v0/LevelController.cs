using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void LevelCheckValidation()
    {
        int levelBonus = int.Parse(findController.levelBonus.text);
        findController.levelBonus.text = Mathf.Clamp(levelBonus, 0, 20).ToString();
    }

    public void LevelBonusUpdater()
    {
        int level = int.Parse(findController.level.text);
        findController.character.level = level;

        if (level < 5)
        {
            findController.levelBonus.text = "2";
        }
        else if (level < 9)
        {
            findController.levelBonus.text = "3";
        }
        else if (level < 13)
        {
            findController.levelBonus.text = "4";
        }
        else if (level < 17)
        {
            findController.levelBonus.text = "5";
        }
        else
        {
            findController.levelBonus.text = "6";
        }
    }
}
