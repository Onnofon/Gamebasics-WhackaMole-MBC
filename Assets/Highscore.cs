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
    private string text;
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
        highscoreText.text = playerScore.ToString();
        
    }
}
