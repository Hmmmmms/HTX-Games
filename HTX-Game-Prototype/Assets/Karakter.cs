using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public static float karakter;


    private void Start()
    {
        karakter = 0;
    }

    public void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = karakter.ToString();
    }


}
