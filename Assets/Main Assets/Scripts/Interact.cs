using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public string interactbutton;

    public float interactdistance = 3f;
    public LayerMask interactLayer;

    public Image interacticon;

    public bool interacting;
    
    // Start is called before the first frame update
    void Start()
    { 
        if (interacticon != null)
        {
            interacticon.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactdistance, interactLayer))
        {
            if (interacting == false)
            {
                if (interacticon != null)
                {
                    interacticon.enabled = true;
                }

                if (Input.GetButtonDown(interactbutton))
                {
                    if (hit.collider.CompareTag("Door"))
                    {
                        hit.collider.GetComponent<Door>().ChangeDoorState();
                    }
                }
            }
        }

    }
}
