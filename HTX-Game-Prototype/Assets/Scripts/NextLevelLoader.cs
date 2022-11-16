using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour
{
    public int loadNextLevelScore;
    private float timer = 0;
    public float maxTime = 1;
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

            if (timer > maxTime)
            {
                LoadScene();
            }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(BeståetLevelToLoad);
    }

}
