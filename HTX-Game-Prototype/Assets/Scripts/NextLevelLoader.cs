using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour
{
    private int loadNextLevelScore = 12;
    private float timer = 0;
    private bool timerOn;

    public string BeståetLevelToLoad;
    void Start()
    {
        timerOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score == loadNextLevelScore)
        {
                timerOn = true;
                if (timerOn == true)
                {
                    timer += Time.deltaTime;
                }
        }

            if (timer > SpawnBoss.maxTimeSpawnBoss && EksamensUI.eksamensTimer == 1)
            {
                    LoadScene();
            }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(BeståetLevelToLoad);
    }

}
