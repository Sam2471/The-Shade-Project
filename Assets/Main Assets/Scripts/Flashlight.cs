using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light flashlight;
    public AudioSource flashlightsource;
    public AudioClip toggleon;
    public AudioClip toggleoff;


    private bool isactive;
   
    void Start()
    {
        isactive = true;
    }

   
    void Update()
    {
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
