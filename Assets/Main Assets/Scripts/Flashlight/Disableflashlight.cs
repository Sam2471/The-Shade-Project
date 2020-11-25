using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disableflashlight : MonoBehaviour
{

    private void OnTriggerEnter(Collider off)
    {
        if (off.CompareTag("Player"))
        {
            Flashlight.canturnon = false;
        }
            
    }  

}
