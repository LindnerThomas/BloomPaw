using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumerTimerHandler : MonoBehaviour
{

    [SerializeField] CustomerObject pointA;
    [SerializeField] CustomerObject pointB;
    [SerializeField] CustomerObject pointC;

    // Update is called once per frame
    void Update()
    {
        if(pointA.isAvailable == false && pointA.timeLeft >= 0){
            pointA.timeLeft -= Time.deltaTime;
        }
         if(pointB.isAvailable == false && pointB.timeLeft >= 0){
            pointB.timeLeft -= Time.deltaTime;
        }
         if(pointC.isAvailable == false && pointC.timeLeft >= 0){
            pointC.timeLeft -= Time.deltaTime;
        }
    }
}
