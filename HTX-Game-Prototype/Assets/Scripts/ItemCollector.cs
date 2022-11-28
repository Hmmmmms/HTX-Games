using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private double Karakter_score;
    private double Amount_of_karaktere;

    private Text Karakter_Count;

    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("12"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;

            

            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + 12);
            Amount_of_karaktere++;
        }
        else if (collision.gameObject.CompareTag("10"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + 10);
            Amount_of_karaktere++;
        }
        else if (collision.gameObject.CompareTag("7"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + 7);
            Amount_of_karaktere++;
        }
        else if (collision.gameObject.CompareTag("4"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + 4);
            Amount_of_karaktere++;
        }
        else if (collision.gameObject.CompareTag("02"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + 2);
            Amount_of_karaktere++;
        }
        else if (collision.gameObject.CompareTag("00"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + 0);
            Amount_of_karaktere++;
        }
        else if (collision.gameObject.CompareTag("-03"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            Karakter_score = (Karakter_score + -3);
            Amount_of_karaktere++;
        }

        if (Amount_of_karaktere > 0)
        {
            Karakter.karakter = Math.Round(Karakter_score / Amount_of_karaktere, 1);
        }
    }

}