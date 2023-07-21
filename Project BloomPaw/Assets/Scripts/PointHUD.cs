using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointHUD : MonoBehaviour
{
    [SerializeField] ScoreObject scoreObject;
    [SerializeField] Text pointText;


    void Update() {
        UpdateHUD();
        
    }
  
    // Update the Score Text Element.
    private void UpdateHUD() {
        pointText.text = scoreObject.score.ToString();

    }


}