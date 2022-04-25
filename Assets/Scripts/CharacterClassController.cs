using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterClassController : MonoBehaviour
{
    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void CharacterClassChanger()
    {
        string characterClassSelected = findController.characterClassSelected.text;
        findController.characterClass.text = characterClassSelected;
        SetCharacterClassToCharacter(characterClassSelected);
    }

    private void SetCharacterClassToCharacter(string characterClassSelected)
    {
        findController.character.characterClass = characterClassSelected;

        switch (characterClassSelected)
        {
            case "Class": SetCharacterClassDefault(); break;
            case "������": SetCharacterClassBarbarian(); break;
            case "����": SetCharacterClassBard(); break;
            case "����": SetCharacterClassCleric(); break;
            case "�����": SetCharacterClassDruid(); break;
            case "����": SetCharacterClassFighter(); break;
            case "�����": SetCharacterClassMonk(); break;
            case "�������": SetCharacterClassPaladin(); break;
            case "��������": SetCharacterClassRanger(); break;
            case "����": SetCharacterClassRogue(); break;
            case "�������": SetCharacterClassSorcerer(); break;
            case "������": SetCharacterClassWarlock(); break;
            case "���������": SetCharacterClassWizard(); break;

            default:
                break;
        }
    }

    private void SetCharacterClassDefault()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassBarbarian()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassBard()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassCleric()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassDruid()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassFighter()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassMonk()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassPaladin()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassRanger()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassRogue()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassSorcerer()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassWarlock()
    {
        throw new NotImplementedException();
    }

    private void SetCharacterClassWizard()
    {
        throw new NotImplementedException();
    }
}
