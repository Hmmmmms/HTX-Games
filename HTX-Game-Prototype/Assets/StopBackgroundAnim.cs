using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundAnim : MonoBehaviour
{
    Animator Background_Anim;

    void Start()
    {
        Background_Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.PauseAnim == true)
        {
            Background_Anim.GetComponent<Animator>().enabled = false;
        }
        else
        {
            Background_Anim.GetComponent<Animator>().enabled = true;
        }
    }
}
