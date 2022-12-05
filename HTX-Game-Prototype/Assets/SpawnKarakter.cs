using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnKarakter : MonoBehaviour
{
    
    public GameObject Prefab0;
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;
    public GameObject Prefab6;

    List<GameObject> prefabList = new List<GameObject>();

    public float maxTime = 1;
    private float timer = 0;
    public float height;
    public float DestroyTimer;

    public int nextLevelScore;

    void Start()
    {
        timer += Time.deltaTime;

        prefabList.Add(Prefab0);
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        prefabList.Add(Prefab4);
        prefabList.Add(Prefab5);
        prefabList.Add(Prefab6);

        int prefabIndex = Random.Range(0, 7);

        GameObject newObject = Instantiate(prefabList[prefabIndex]);
        newObject.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newObject, DestroyTimer);
    }

    // Update is called once per frame
    void Update()
    {
        if ((Score.score < nextLevelScore-2) && (timer > maxTime))
        {
            int prefabIndex = Random.Range(0, 7);

            GameObject newObject = Instantiate(prefabList[prefabIndex]);
            newObject.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObject, DestroyTimer);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}
