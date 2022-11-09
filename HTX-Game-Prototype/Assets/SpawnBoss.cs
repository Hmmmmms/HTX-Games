using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    public int BossSpawnScore;
    public GameObject Object;
    public float maxTime = 1;
    private float timer = 0;
    private bool timerOn;

    private bool spawned = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Score.score == BossSpawnScore)
        {
            timerOn = true;
            if (timerOn == true)
            {
                timer += Time.deltaTime;
            }
        }

        if (timer > maxTime && spawned == false)
        {
            Instantiate(Object);

            spawned = true;
        }

    }
}
