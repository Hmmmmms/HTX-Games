using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) || (Input.GetKeyDown("up")) || (Input.GetKeyDown("space")) || (Input.GetKeyDown("w")))
        {
            // Jump
            rb.velocity = Vector2.up * velocity;
        }

    
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
            {
                gameManager.GameOver();


            }

}
