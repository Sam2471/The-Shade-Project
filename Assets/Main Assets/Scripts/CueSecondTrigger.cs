using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CueSecondTrigger : MonoBehaviour
{
    public AudioSource footstepsource;
    public AudioClip footstep;
    private bool hasplayedfootstep = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasplayedfootstep == false)
        {
            footstepsource.PlayOneShot(footstep);
            //hasplayedfootstep = true;
        }
    }
}
