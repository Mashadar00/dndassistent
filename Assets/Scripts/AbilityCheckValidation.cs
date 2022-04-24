using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AbilityCheckValidation : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void CheckValidation()
    {
        TMP_InputField ability = gameObject.GetComponent<TMP_InputField>();
        ability.text = Mathf.Clamp(int.Parse(ability.text), 0, 30).ToString();
    }
}
