using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Highscore : MonoBehaviour
{
    public int[] playerScore;
    public TextMeshProUGUI highscoreText;
    private void Start()
    {
        Array.Sort(playerScore);
        UpdateHighScore();

    }
    public void SortHighscore()
    {
        playerScore.OrderBy(score => score);
    }
    public void UpdateHighScore()
    {
        for (int i = 0; i < playerScore.Length; i++)
        {
            Debug.Log("hi");
            highscoreText.text += playerScore[i].ToString() + "\n";
        }
        
    }
}
