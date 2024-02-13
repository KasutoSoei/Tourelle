using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isPlaying = true; //set to false when player met win or loss conditions

    public float RemainingTime = 30f; //remaining time before the player win the game
    public Text timeValue; //text used to show remaining time to player

    public int score = 0; //points
    public Text scoreValue; //text used to show score to player

    public Text EndGameText; //text used to show the endgame message


    public void PlayerIsDeadStopGame()
    {
        //if the player is dead, displays a defeat message
        isPlaying = false;
        EndGameText.text = "YOU LOST";
    }

    public void PlayerWin()
    {
        //if the play time is over and the player still alive, displays a victory message
        isPlaying = false;
        EndGameText.text = "YOU WON !";
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying && RemainingTime > 0)
        {
            //reduce reamining time at each frame
            RemainingTime -= Time.deltaTime;
            timeValue.text = RemainingTime.ToString();

            //if the play time is over
            if (RemainingTime <= 0 && isPlaying)
            {
                PlayerWin();
            }            
        }

        //assigns to the scoreValue text the value of the score variable
        scoreValue.text = score.ToString();
    }
}
