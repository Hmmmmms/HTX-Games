using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject startGameCanvas;
    public GameObject gameUI;
    public GameObject EksamensCanvas;
    public static bool PauseAnim;
    public static bool PauseInputGameOver;
    public static bool Eksamensrunde;

    private void Start()
    {
        startGameCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        EksamensCanvas.SetActive(false);
        gameUI.SetActive(false);
        Time.timeScale = 0;
        PauseAnim = false;
        PauseInputGameOver = false;
        Eksamensrunde = false;
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

    public void EksamensRunde()
    {
        gameUI.SetActive(false);
        EksamensCanvas.SetActive(true);
        Eksamensrunde = true;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
