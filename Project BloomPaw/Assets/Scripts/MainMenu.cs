using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

   public AudioClip audio;
   public AudioSource audioSource;

  // Handles the player's action to switch to another scence and playing audio before transitioning to the flower shop scene.
   public void PlayGame(){
       audioSource.Play();
      StartCoroutine(_PlayGame());
   }


   public void GoBack(){
      audioSource.Play();
      StartCoroutine(_GoBack());
   }
 
   private IEnumerator _PlayGame(){
        yield return new WaitForSeconds(audio.length);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
   }
   
   private IEnumerator _GoBack(){
        yield return new WaitForSeconds(audio.length);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
   }

   public void OpenWorkBench(){
        audioSource.Play();
        StartCoroutine(_OpenWorkBench());
   }

   private IEnumerator _OpenWorkBench()
   {
        yield return new WaitForSeconds(audio.length);
        SceneManager.LoadScene(4);
   }

   public void QuitGame(){
        audioSource.Play();
        Application.Quit();
        Debug.Log("Quit works");
   }
}
