using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int holes;
    public float time;
    public int score;
    public bool gameActive;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    //Countdown timer when countdown reaches 0 stop game function is called
    void Update()
    {
        time -= Time.deltaTime;
        scoreText.text = "Score: " + score;
        timerText.text = "Time left: " + time.ToString("F1");
        if (time < 0)
        {
            //stopgame
        }
    }

    public void GetPoints(int points)
    {
        score += points;
    }
}
