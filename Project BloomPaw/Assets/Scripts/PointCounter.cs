using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    [SerializeField] ScoreObject scoreObject;
    [SerializeField] PointHUD pointHUD;
    bool gameStopped = false;
    public bool gameActive = false;

    public void StartGame() {
        StartCoroutine(CountPoints());
        gameActive = true;
    }

    public void StopGame() {
        gameStopped = true;
        gameActive = false;
    }

    private IEnumerator CountPoints() {
        while (!gameStopped) {
            scoreObject.updateScore();

            yield return new WaitForSeconds (1);
        }
    }
}