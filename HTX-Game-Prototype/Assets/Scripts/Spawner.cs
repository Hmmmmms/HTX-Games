using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject Object;
    public float height;
    public float DestroyTimer;

    public int nextLevelScore;

    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if ((Score.score < nextLevelScore-1) && (timer > maxTime))
        {
            GameObject newObject = Instantiate(Object);
            newObject.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObject, DestroyTimer);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}
