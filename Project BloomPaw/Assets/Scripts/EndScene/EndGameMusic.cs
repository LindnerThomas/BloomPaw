using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMusic : MonoBehaviour
{
     void Start()
    {
         Destroy (GameObject.FindWithTag("GameMusic2"));
    }
}
