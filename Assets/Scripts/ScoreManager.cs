using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private ScoreData sd;

    //Check if playerprefs is empty or else load the data
    private void Awake()
    { 
        
        string json = PlayerPrefs.GetString("scores", "{}");
        if (string.IsNullOrEmpty(json) == true)
        {
            Debug.Log("empty");
            sd = new ScoreData();
        }
        else
        {
            Debug.Log("not empty");
            sd = JsonUtility.FromJson<ScoreData>(json);
        }
    }

    //Sort the highscore for ranking system
    public IEnumerable<Score> GetHighScores()
    {
        return sd.scores.OrderByDescending(x => x.score);
    }

    //Add score to data
    public void AddScore(Score score)
    {
        sd.scores.Add(score);
    }

    private void OnDestroy()
    {
        SaveScore();
    }

    //Save scores to current playsession
    public void SaveScore()
    {
        string json = JsonUtility.ToJson(sd);
        PlayerPrefs.SetString("scores", json.ToString());
    }
}
