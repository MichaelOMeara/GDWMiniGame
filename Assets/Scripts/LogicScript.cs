using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

    public int PlayerScore;
    public Text Score;
    public GameObject gameOverScreen;

    [ContextMenu("Score Increase")]

    public void AddScore(int ScoreToAdd)
    {
        PlayerScore += ScoreToAdd;
        Score.text = PlayerScore.ToString();


    }

    public void GameReset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
