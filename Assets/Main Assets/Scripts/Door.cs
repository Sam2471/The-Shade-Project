using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open = false;
    public bool canopen = false;

    public float dooropenangle = 90f;
    public float doorcloseangle = 0f;

    public float smooth = 2f; // speed of rotation 

    public void ChangeDoorState()
    {
        open = !open;
    }
    // Update is called once per frame

    void Update()
    {       
        {

            if (canopen == true && Input.GetKeyDown(KeyCode.E))
            {
                ChangeDoorState();             
            }

            if (open)
            {
                Doortrigger.test = true;
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
