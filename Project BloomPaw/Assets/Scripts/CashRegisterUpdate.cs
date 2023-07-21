using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CashRegisterUpdate : MonoBehaviour
{

    [SerializeField] Text registerText;
    [SerializeField] ScoreObject scoreObject;


    // Update the Text on the Cash Register
    void Update()
    {
        registerText.text = scoreObject.lastChange.ToString();
    }
}
