using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScriptDinna : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject player;

    public float force;
    public int bulletDestroy;


    // Use this for initialization
    void Start()
    {

        int randomShootHeight = Random.Range(0, 2);

        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x, direction.y + randomShootHeight).normalized * force;
        Destroy(gameObject, bulletDestroy);

    }

}
