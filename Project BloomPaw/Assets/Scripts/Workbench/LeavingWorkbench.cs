using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeavingWorkbench : MonoBehaviour
{

    [SerializeField] CustomerObject pointA;
    [SerializeField] CustomerObject pointB;
    [SerializeField] CustomerObject pointC;
    public AudioClip audio;
    public AudioSource audioSource;
    
    // Handles the player's return to the flower shop from a processing point by resetting their state and playing audio before transitioning to the flower shop scene.

    public void BackToFlowershop(){
        if(pointA.inProcess ){
            pointA.inProcess = false;
        }
         if(pointB.inProcess ){
            pointB.inProcess = false;
        }
         if(pointC.inProcess ){
            pointC.inProcess = false;
        }

        audioSource.Play();
        StartCoroutine(BackToFlowershop_Action());
        

    }

    private IEnumerator BackToFlowershop_Action(){
        yield return new WaitForSeconds(audio.length);
        SceneManager.LoadScene(2);
   }
}
