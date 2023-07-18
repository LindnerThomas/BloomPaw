using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] Timer timer;
    public Text timeText;


    private void Update()
    {
        
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
;
        }
    }
}
