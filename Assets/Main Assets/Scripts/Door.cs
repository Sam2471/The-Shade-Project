using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool open = false;

    public float dooropenangle = 90f;
    public float doorcloseangle = 0f;

    public float smooth = 2f; // speed of rotation 

    private AudioSource doorsource;
    public AudioClip opensound;

    public void Start()
    {
        doorsource = GetComponent<AudioSource>();
    }

    public void ChangeDoorState()
    {
        open = !open;

        if (doorsource != null)
        {
            doorsource.PlayOneShot(opensound);
        }
    }
    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            open = !open;

            if (doorsource != null)
            {
                doorsource.PlayOneShot(opensound);
            }

        }

        if (open == true)
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
