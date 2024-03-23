using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    void Start()
    {
        score = 0;
    }//Start

    
    void Update()
    {
        
    }//Update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Hit Point") 
        {
            score++;
            scoreText.text = "SCORE :  " + score;
        }
    }//OnTriggerEnter

}//ScoreManager
