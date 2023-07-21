using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameHandler : MonoBehaviour
{

    [SerializeField] Timer timer;
    [SerializeField] ScoreObject scoreObject;
    [SerializeField] HighscoreHandler HighscoreHandler;
    [SerializeField] PointHUD pointHUD;
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


    // Switching to the end scene when the timer runs out
    void Update(){
        if(timer.time <= 0){
            StopGame();
            SceneManager.LoadScene(5); 
        }

    }


    
    // Reseting all Values for the next game
    public void StopGame() {
       // HighscoreHandler.SetHighscoreIfGreater(pointHUD.Points);
        HighscoreHandler.AddHighscoreIfPossible(new InputEntry(PlayerPrefs.GetString("name"), scoreObject.score));
        timer.resetTime();
        flower1.flowerCount = 3;
        flower2.flowerCount = 3;
        flower3.flowerCount = 3;
        flower4.flowerCount = 3;
        flower5.flowerCount = 3;
        flower6.flowerCount = 3;
        flower7.flowerCount = 3;
        flower8.flowerCount = 3;
        flower9.flowerCount = 3;
        flower10.flowerCount = 3;
        pointA.timeLeft = 30f;
        pointA.isDone = false;
        pointA.isAvailable = true;
        pointB.timeLeft = 30f;
        pointB.isDone = false;
        pointB.isAvailable = true;
        pointC.timeLeft = 30f;
        pointC.isDone = false;
        pointC.isAvailable = true;
        pointC.inProcess = false;
        pointB.inProcess = false;
        pointA.inProcess = false;
        scoreObject.lastChange = 0;


    }
}
