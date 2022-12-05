using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    Animator bird_Anim;
    [SerializeField] private AudioSource Flap;
    [SerializeField] private AudioSource BossRawr;
    private bool hasPlayedBossRawr = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bird_Anim = GetComponent<Animator>();
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        if(Score.score == 12 && EksamensUI.FreezePosUntilBoss == true)
        {
            
            waiter();
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            gameManager.BossMinecraftChat();
            if (hasPlayedBossRawr == false)
            {
                BossRawr.Play();
                hasPlayedBossRawr = true;
            }
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.None;
            
        }
 

        if (GameManager.PauseInputGameOver == false)
        {
            if ((Input.GetMouseButtonDown(0)) || (Input.GetKeyDown("up")) || (Input.GetKeyDown("space")) || (Input.GetKeyDown("w")))
            {
                Time.timeScale = 1;

                if (GameManager.Eksamensrunde == false)
                {
                    gameManager.StartGame();
                }

                rb.velocity = Vector2.up * velocity;
                Flap.Play();
            }
        }

        if (GameManager.PauseAnim == true)
        {
            bird_Anim.GetComponent<Animator>().enabled = false;
        }
        else
        {
            bird_Anim.GetComponent<Animator>().enabled = true;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
            {
                gameManager.GameOver();


            }

    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(1/2);
    }

}
