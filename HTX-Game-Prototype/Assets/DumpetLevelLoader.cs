using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DumpetLevelLoader : MonoBehaviour
{
    public int loadNextLevelScore;
 
    public string DumpetLevelToLoad;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score == loadNextLevelScore && Karakter.karakter < 2)
        {
           
                DumpetLoadScene();
        }
    
    void DumpetLoadScene()
    {
        SceneManager.LoadScene(DumpetLevelToLoad);
    }

}
    }
