using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource successSFX;
    public AudioClip successClip;
    public bool gameIsRunning = true;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        if (gameIsRunning)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();
            successSFX.PlayOneShot(successClip);
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameIsRunning = false;
    }
}
