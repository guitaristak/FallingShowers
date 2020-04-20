using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score;
    public static int scoreText;
    void Update()
    {
        score.text = "X" + scoreText.ToString();
    }
}
