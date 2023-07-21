using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;

public class AddScore : MonoBehaviour
{
    [SerializeField] InventoryItem flower1;
    [SerializeField] InventoryItem flower2;
    [SerializeField] InventoryItem flower3;
    [SerializeField] InventoryItem flower4;
    [SerializeField] InventoryItem flower5;
    [SerializeField] InventoryItem flower6;
    [SerializeField] InventoryItem flower7;
    [SerializeField] InventoryItem flower8;
    [SerializeField] InventoryItem flower9;
    [SerializeField] InventoryItem flower10;
    
    [SerializeField] CustomerObject pointA;
    [SerializeField] CustomerObject pointB;
    [SerializeField] CustomerObject pointC;
    [SerializeField] ScoreObject scoreObject;
    public int[] choosenFlowers = new int[3];
    public int choosenFlower1;
    public int choosenFlower2;
    public int choosenFlower3;
    public int[] customerFlower = new int[3];
    



    // Updates the player's score based on the number of correct flower choices made at processing points (pointA, pointB, or pointC).
    // Each correct match adds 5 points to the player's score.
    public void IncreaseScore(){
        if (pointA.inProcess){
            customerFlower[0] = pointA.flower0;
            customerFlower[1] = pointA.flower1;
            customerFlower[2] = pointA.flower2;   
            int correctNumberOfFlowers =  CountMatchingElements(customerFlower, choosenFlower1, choosenFlower2, choosenFlower3);
            scoreObject.score += correctNumberOfFlowers * 5;
            scoreObject.lastChange = correctNumberOfFlowers * 5;
            pointA.inProcess = false;
            pointA.isDone = true;
            
        }
        else if (pointB.inProcess){
            customerFlower[0] = pointB.flower0;
            customerFlower[1] = pointB.flower1;
            customerFlower[2] = pointB.flower2;   
            int correctNumberOfFlowers =  CountMatchingElements(customerFlower, choosenFlower1, choosenFlower2, choosenFlower3);
            scoreObject.score += correctNumberOfFlowers * 5;
            pointB.inProcess = false;
            pointB.isDone = true;
            
        }
        else if (pointC.inProcess){
            customerFlower[0] = pointC.flower0;
            customerFlower[1] = pointC.flower1;
            customerFlower[2] = pointC.flower2;   
            int correctNumberOfFlowers =  CountMatchingElements(customerFlower, choosenFlower1, choosenFlower2, choosenFlower3);
            scoreObject.score += correctNumberOfFlowers * 5;
            pointC.inProcess = false;
            pointC.isDone = true;
            
        }
       
       
    }
    
    // Counts the number of elements in 'array' that match the elements in 'inputArray'
    // and returns the count of matching elements.
    public int CountMatchingElements(int[] array, int num1, int num2, int num3){
        int[] inputArray = new int[] { num1, num2, num3 };
        int[] checkArray = array;
        int counter = 0;

        for (int i = 0; i < inputArray.Length; i++){
            if(checkArray.Contains(inputArray[i])){
                checkArray[Array.IndexOf(checkArray, inputArray[i])] = -1;
                counter++;
            }
        }
        return counter;

    }

   // Switches back to the Flowershop when we are done with the order
   public void toFlowershop(){ 
        SceneManager.LoadScene(2);
   }

    // Decreases the count of a specific flower in the inventory based on the provided index (0 to 9).
   public void decreaseInventory(int num1){
        switch(num1) 
        {           
                case 0:
                    if (flower1.flowerCount > 0){
                        flower1.flowerCount--;
                        break;
                    }
                    break;
                case 1:
                    if (flower2.flowerCount > 0){
                        flower2.flowerCount--;
                         break;
                    }
                    break;
                case 2:
                    if (flower3.flowerCount > 0){
                        flower3.flowerCount--;
                         break;
                    }
                    break;
                case 3:
                    if (flower4.flowerCount > 0){
                        flower4.flowerCount--;
                         break;
                    }
                     break;
                case 4:
                    if (flower5.flowerCount > 0){
                        flower5.flowerCount--;
                         break;
                    }
                     break;
                case 5:
                    if (flower6.flowerCount > 0){
                        flower6.flowerCount--;
                         break;
                    }
                     break;
                case 6:
                    if (flower7.flowerCount > 0){
                        flower7.flowerCount--;
                         break;
                    }
                     break;
                case 7:
                    if (flower8.flowerCount > 0){
                        flower8.flowerCount--;
                         break;
                    }
                     break;
                case 8:
                    if (flower9.flowerCount > 0){
                        flower9.flowerCount--;
                         break;
                    }
                     break;
                case 9:
                    if (flower10.flowerCount > 0){
                        flower10.flowerCount--;
                         break;
                    }
                    break;
                default:
                    Debug.Log("its not 1-10");
                    break;
        }    
   }
}
