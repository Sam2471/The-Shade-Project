using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deskevent : MonoBehaviour
{
    public Light lamp;
    public Light direction;
    public bool hasplayed = true;

    public AudioSource desksource;
    public AudioClip scaresound;
    

    void Start()
    {
        lamp.enabled = false;
        direction.enabled = false;
      
    }

    private void OnTriggerEnter(Collider startdeskevent)
    {
        if (startdeskevent.CompareTag("Player") && hasplayed == true)
        {
            lamp.enabled = true;
            direction.enabled = true;
            desksource.PlayOneShot(scaresound);
            hasplayed = false;
            
        }
    }

   

    
    void Update()
    {
        
    }
}
