using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    public bool Canopen = false;
    public Collider doortrigger;
    public bool test = false;

    private AudioSource doorsource;
    public AudioClip opensound;

    public void Start()
    {
        doorsource = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider doortrigger)
    {
        if (doortrigger.CompareTag("Player"))
        {
            Canopen = true;
        }       
    }

    public void OnTriggerExit(Collider doortrigger)
    {
        if (doortrigger.CompareTag("Player"))
        {
            Canopen = false;
        }
            
    } 
        private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Canopen == true)
        {
            test = true;
            Door.open = !Door.open;
            if (doorsource != null)
            {
                doorsource.PlayOneShot(opensound);
            }
            

        }

    }
}
