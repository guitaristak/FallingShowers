using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI endScoreText;
    public static int score;
    public static int highScore;
    void Start()
    {
        //highScore = PlayerPrefs.GetInt("highscore");
    }
    void Update()
    {
        scoreText.text = "X" + score.ToString();
        if (MovePlayer.isAlive == false)
        {
            if (score > highScore)
            {
                highScore = score;
                SaveData();
            }
            endScoreText.text = "SCORE : " + score.ToString();
            highScoreText.text = "HIGH SCORE : " + highScore;
        }
    }
    public static void SaveData()
    {
        PlayerPrefs.SetInt("highScore", highScore);
    }
    public static void LoadData()
    {
        highScore = PlayerPrefs.GetInt("highScore");
    }
}
