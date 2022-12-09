using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalFlyScript : MonoBehaviour
{
    public float velocity = 1;
    public float speed = 1;
    private Rigidbody2D rb;
    Animator bird_Anim;
    [SerializeField] private AudioSource Flap;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bird_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (dirX * speed, rb.velocity.y);

        if ((Input.GetMouseButtonDown(0)) || (Input.GetKeyDown("up")) || (Input.GetKeyDown("space")) || (Input.GetKeyDown("w")))
        {
            rb.velocity = new Vector2(rb.velocity.x, velocity);
            Flap.Play();
        }
        
    }
}
