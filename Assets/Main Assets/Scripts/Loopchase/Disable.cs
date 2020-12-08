using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour
{
    public Topstart starttop;

    private void OnTriggerEnter(Collider other)
    {
        starttop.canstart = false;
        
    }
}
