using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class showEndScore : MonoBehaviour
{
    [SerializeField] ScoreObject score;
    [SerializeField] Text scoreText;
    public AudioClip audio;
    public AudioSource audioSource;
    public AudioSource audioSourceQuit;

   
    void Start(){
        scoreText.text = score.score.ToString();
    }

    public void goMainMenu(){
      audioSource.Play();
      score.resetScore();
      StartCoroutine(_goMainMenu());
    }

     private IEnumerator _goMainMenu(){
        yield return new WaitForSeconds(audio.length);
        SceneManager.LoadScene(0);
   }



    public void quitGame(){
        score.resetScore();
        audioSourceQuit.Play();
        Application.Quit();
        Debug.Log("Quit works");
   }


}
