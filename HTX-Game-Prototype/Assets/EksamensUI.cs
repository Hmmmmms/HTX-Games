using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EksamensUI : MonoBehaviour
{
    public GameManager gameManager;
    private float timer = 0;
    private bool timerOn;
    private float eksamensminusTimer;
    public static float eksamensTimer = 0;
    public static bool FreezePosUntilBoss;
    void Start()
    {
        timer = 0;
        eksamensTimer = 0;
        FreezePosUntilBoss = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Score.score == 12)
        {
            timerOn = true;
            if (timerOn == true)
            {
                timer += Time.deltaTime;
            }
        }

        if (timer > SpawnBoss.maxTimeSpawnBoss)
        {
            FreezePosUntilBoss = false;
            gameManager.EksamensRunde();

            eksamensminusTimer += Time.deltaTime;

            eksamensTimer = 20 - Mathf.FloorToInt(eksamensminusTimer);


        }
    }
}

