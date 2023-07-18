using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameHandler : MonoBehaviour
{

    [SerializeField] Timer timer;
    [SerializeField] ScoreObject scoreObject;
    [SerializeField] PointCounter pointCounter; //Singelton
    [SerializeField] HighscoreHandler HighscoreHandler;
    [SerializeField] PointHUD pointHUD;
    //[SerializeField] InputField playerName;
    public void StartGame() {
        if (pointCounter.gameActive == false){
            pointCounter.StartGame();
        }
       
    }

    void Update(){
        if(timer.time <= 0){
            StopGame();
            SceneManager.LoadScene(5);

            
        }

    }

    void Start(){
        pointCounter.StartGame();
    }

    

    public void StopGame() {
       // HighscoreHandler.SetHighscoreIfGreater(pointHUD.Points);
        HighscoreHandler.AddHighscoreIfPossible(new InputEntry(PlayerPrefs.GetString("name"), scoreObject.score));
        scoreObject.resetScore();
        timer.resetTime();
        pointCounter.StopGame();

    }
}
