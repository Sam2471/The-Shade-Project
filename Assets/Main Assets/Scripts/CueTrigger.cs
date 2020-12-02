using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueTrigger : MonoBehaviour
{
    public AudioSource thundersource;
    public AudioClip thunder;
    private bool hasplayedthunder = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && hasplayedthunder == false)
        {
            thundersource.PlayOneShot(thunder);
            hasplayedthunder = true;
        }
    }
}
