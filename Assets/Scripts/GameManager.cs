using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int holes;
    public float time;
    public int playerScore;
    public string playerName;
    public bool gameActive;
    public ScoreManager scoreManager;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    //Countdown timer when countdown reaches 0 stop game function is called
    void Update()
    {
        time -= Time.deltaTime;
        scoreText.text = "Score: " + playerScore;
        timerText.text = "Time left: " + time.ToString("F1");
        if (time < 0)
        {
            scoreManager.AddScore(new Score(name: playerName, score: playerScore));
        }
    }

    public void GetPoints(int points)
    {
        playerScore += points;
    }

    public void OnEnable()
    {
        playerName = PlayerPrefs.GetString("name");
        holes = PlayerPrefs.GetInt("holes");
    }
}
