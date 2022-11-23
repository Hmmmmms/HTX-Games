using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DumpetLevelLoader : MonoBehaviour
{
    public int loadNextLevelScore;
    private float timer = 0;
    public float maxTime = 1;
    private bool timerOn;


    public string DumpetLevelToLoad;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score == loadNextLevelScore && Karakter.karakter < 2)
        {
            timerOn = true;
            if (timerOn == true)
            {
                timer += Time.deltaTime;
            }
        }

        if (timer > maxTime)
        {
           DumpetLoadScene();
        }
        }
    
    void DumpetLoadScene()
    {
        SceneManager.LoadScene(DumpetLevelToLoad);
    }

}

