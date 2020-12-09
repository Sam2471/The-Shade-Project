using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topstart : MonoBehaviour
{
    public bool canstart = true;
    public bool testyo = false;
    public bool hasbroken = false;

    public GameObject triggerbox;
    public GameObject lightB;
    public GameObject lightC;
    public Light lightF;
    public GameObject disablebox;

    public AudioSource smashsource;
    public AudioSource approchS;
    public AudioClip smashsound;   
    public AudioClip approchC;

    public Flashlight flash;
   
    private void Start()
    {
       
    }

    private void Update()
    {
        if (canstart == false)
        {
            triggerbox.SetActive(false);
        }
        if (hasbroken == true)
        {
           lightB.SetActive(true);
           lightC.SetActive(true);
           flash.canflick = false;
            lightF.intensity = 1f;
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasbroken == false)
        {
            disablebox.SetActive(false);
            smashsource.PlayOneShot(smashsound);
            approchS.PlayOneShot(approchC);
            lightB.SetActive(false);
            lightC.SetActive(false);
            flash.canflick = true;
            StartCoroutine(Lightrepair());
            
        }
        
   
    }

    IEnumerator Lightrepair()
    {              
        yield return new WaitForSeconds(10);
        yield return hasbroken = true;
        yield return testyo = true;
        
    }
}
