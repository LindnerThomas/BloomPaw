using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] AudioSource audioSource;
    public Text timeText;
    private bool countdown = true;


    // Updates the timer countdown, reducing the remaining time by Time.deltaTime until it reaches zero.
    // The method displays the updated time and checks if the time has reached the last minute.
    private void Update()
    {

        CountDownPlay();

        if(timer.time > 0)
        {
            timer.time -= Time.deltaTime;
        }
        else
        {
            timer.time = 0;
        }

        DisplayTime(timer.time);
        lastMinute();
      
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void lastMinute(){
        if(timer.time < 60){
            GetComponent<Text>().color = new Color(255,0,0);
        }       
    }

    public void CountDownPlay(){   
        
        if (timer.time < 4 && countdown){
            audioSource.Play();
            countdown = false;
        }
           
    }
}
