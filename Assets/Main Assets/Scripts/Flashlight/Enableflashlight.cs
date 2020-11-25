using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enableflashlight : MonoBehaviour
{

    private void OnTriggerExit(Collider on)
    {
        if (on.CompareTag("Player"))
        {
            Flashlight.canturnon = true;
            Flashlight.wason = true;
        }
            
    }

}
