using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    public AudioSource flashlightsource;
    public AudioClip toggleon;
    public AudioClip toggleoff;

    public static bool canturnon = true;
    public static bool wason;

    private bool isactive;
   
    void Start()
    {
        isactive = true;
    }


    void Update()
    {
        if (canturnon == false)
        {
            flashlight.enabled = false;
            isactive = false;
        }

        if (canturnon == true)
        {
            if (wason == true)
            {
                flashlight.enabled = true;
                isactive = true;
                flashlightsource.PlayOneShot(toggleon);
                wason = false;
            } 
                
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (isactive == false)
                {
                    flashlight.enabled = true;
                    isactive = true;
                    flashlightsource.PlayOneShot(toggleon);
                }
                else if (isactive == true)
                {
                    flashlight.enabled = false;
                    isactive = false;
                    flashlightsource.PlayOneShot(toggleoff);
                }

            }

       
        } 
    }
}
