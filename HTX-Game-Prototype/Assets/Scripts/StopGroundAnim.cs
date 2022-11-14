using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGroundAnim : MonoBehaviour
{
    Animator ground_Anim;

    void Start()
    {
        ground_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.PauseAnim == true)
        {
            ground_Anim.GetComponent<Animator>().enabled = false;
        }
        else
        {
            ground_Anim.GetComponent<Animator>().enabled = true;
        }
    }
}
