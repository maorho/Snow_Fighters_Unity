using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class gameOverScript : MonoBehaviour
{
    [SerializeField] public Text winner;
    [SerializeField] public Text pointsText;
    public void setup(string scorePlayer1, string scorePlayer2)
    {
        gameObject.SetActive(true);
        if (Int32.Parse(scorePlayer1) > Int32.Parse(scorePlayer2))
            winner.text = "player 1 won!";
        else if (Int32.Parse(scorePlayer1) < Int32.Parse(scorePlayer2))
            winner.text = "player 2 won!";
        else if (Int32.Parse(scorePlayer1) == Int32.Parse(scorePlayer2))
            winner.text = "Tie!";
        pointsText.text = "player 1 with " + scorePlayer1 + " coins\n" +
            "player 2 with " + scorePlayer2 + " coins";
    }
}
