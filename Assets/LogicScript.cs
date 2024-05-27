using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public string sceneName;
   [ContextMenu("Increase Score")] 
    public void AddScore(int scoretoAdd) 
    {
        playerScore += scoretoAdd;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void RestartGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
    public void MainMenu() 
    {
        SceneManager.LoadScene(sceneName);
    }
}
