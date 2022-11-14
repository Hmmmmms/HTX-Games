using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class SpawnLoadLevel : MonoBehaviour
{
    public int nextLevelScore;
    public GameObject Object;
    private bool spawned = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if(Score.score == nextLevelScore && spawned == false)
        {
            Instantiate(Object);

            spawned = true;
        } 

    }
}
