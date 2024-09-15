using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    private int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    public void CheckForNewHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
}
