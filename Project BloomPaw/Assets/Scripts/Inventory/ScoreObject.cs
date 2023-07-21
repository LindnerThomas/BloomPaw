using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Score")]
public class ScoreObject : ScriptableObject
{
    // Integer for the overall score and for the Last Order
    public int score;
    public int lastChange;
    

    public void updateScore(){
        score += 5;
    }

    public void resetScore(){
        score = 0;
    }

   
   
}
