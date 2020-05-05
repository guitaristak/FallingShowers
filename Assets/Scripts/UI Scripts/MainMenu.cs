using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI hs;
    public void PlayGame()
    {
        MovePlayer.isAlive = true;
        Health.health = 3;
        ScoreManager.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void HighScore()
    {
        hs.text = ScoreManager.highScore.ToString();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
