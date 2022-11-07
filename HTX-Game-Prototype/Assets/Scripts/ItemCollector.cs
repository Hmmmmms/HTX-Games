using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int Coins = 0;

    [SerializeField] private Text Coin_Count;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Coins"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;

            

            Destroy(collision.gameObject);

            Coins++;
            Coin_Count.text = Convert.ToString(Coins);
        }

    }

}