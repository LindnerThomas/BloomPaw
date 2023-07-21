using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "CustomerObject", menuName = "CustomerObject")]
public class CustomerObject : ScriptableObject
{
    public int flower0;
    public int flower1;
    public int flower2;
    public bool inProcess;
    public float timeLeft;
    public int customerSpriteID;
    public bool isDone;
    public bool isAvailable = true;

    public void SetInProcess(){
       if(inProcess == false){
        inProcess = true;
       }
       else if(inProcess == true)
       {
        inProcess = false;
       }
    }


    

    
   
   
}
