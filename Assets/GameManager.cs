using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int holes;
    public float time;
    public int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    // Update is called once per frame
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
}
