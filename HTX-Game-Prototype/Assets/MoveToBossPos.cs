using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToBossPos : MonoBehaviour
{

    private float maxTime = 1;
    private float timer = 0;

    private Rigidbody2D rb;
    public static bool bossPoss = false;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if(Score.score == 12)
        {

            timer += Time.deltaTime;
            
        }


        if(timer > maxTime && EksamensUI.eksamensTimer == 20)
        {
            transform.position = new Vector3(-0.5f, 0f, 0f);
            
            timer = 0;
        }
    }
}
