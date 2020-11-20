using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public static bool open = false;

    public float dooropenangle = 90f;
    public float doorcloseangle = 0f;

    public GameObject maindoor;

    public float smooth = 2f; // speed of rotation 

    public void ChangeDoorState()
    {
        open = !open;
    }
    // Update is called once per frame

    void Update()
    {       
        {

            if (open)
            {
                Quaternion targetRotationOpen = Quaternion.Euler(0, dooropenangle, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationOpen, smooth * Time.deltaTime);

                
            }

            else
            {
                Quaternion targetRotationClosed = Quaternion.Euler(0, doorcloseangle, 0);
                transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotationClosed, smooth * Time.deltaTime);
                
            }
        }
    }
}
