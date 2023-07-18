using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Score")]
public class ScoreObject : ScriptableObject
{
    public int score;
    

    public void updateScore(){
        score += 5;
    }

    public void resetScore(){
        score = 0;
    }

   
   
}
