using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Xml.Serialization;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public int pointsPerSecond = 1;
    private float scoreTimer;
    public GameObject gameOverScreen;

    private void Update()
    {
        scoreTimer += Time.deltaTime;
        if (scoreTimer >= 1f)
        {
            addScore();
            scoreTimer = 0f;
        }
    }
    public void addScore()
    {
        playerScore += pointsPerSecond;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
