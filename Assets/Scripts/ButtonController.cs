using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    GameObjectFindController findController;

    private void Start()
    {
        findController = GameObject.Find("Canvas").GetComponent<GameObjectFindController>();
    }

    public void ToLeftPage()
    {
        if (findController.characterLists[0].activeInHierarchy)
        {
            findController.characterLists[0].SetActive(false);
            findController.characterLists[findController.characterLists.Length - 1].SetActive(true);
        }
        else
        {
            for (int i = 1; i < findController.characterLists.Length; i++)
            {
                if (findController.characterLists[i].activeInHierarchy)
                {
                    findController.characterLists[i].SetActive(false);
                    findController.characterLists[i - 1].SetActive(true);
                    break;
                }
            }
        }
    }
    public void ToRightPage()
    {
        if (findController.characterLists[findController.characterLists.Length - 1].activeInHierarchy)
        {
            findController.characterLists[0].SetActive(true);
            findController.characterLists[findController.characterLists.Length - 1].SetActive(false);
        }
        else
        {
            for (int i = 0; i < findController.characterLists.Length; i++)
            {
                if (findController.characterLists[i].activeInHierarchy)
                {
                    findController.characterLists[i].SetActive(false);
                    findController.characterLists[i + 1].SetActive(true);
                    break;
                }
            }
        }
    }
}
