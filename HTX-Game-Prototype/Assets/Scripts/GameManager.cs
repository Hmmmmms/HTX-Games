using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject startGameCanvas;
    public GameObject gameUI;
    public static bool PauseAnim;
    public static bool PauseInputGameOver;

    private void Start()
    {
        startGameCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        gameUI.SetActive(false);
        Time.timeScale = 0;
        PauseAnim = false;
        PauseInputGameOver = false;
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        PauseAnim = true;
        PauseInputGameOver = true;
    }

    
    public void StartGame()
    {
        startGameCanvas.SetActive(false);
        gameUI.SetActive(true);
        PauseInputGameOver = false;
    }


    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

}
