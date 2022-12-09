using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollector : MonoBehaviour
{

    [SerializeField] private AudioSource collectionSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Coins"))
        {
            string collectableItem = collision.gameObject.GetComponent<Collectable>().collectableItem;



            Destroy(collision.gameObject);

            collectionSound.Play();
        }
    }
}
