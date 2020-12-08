using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procesmenu : MonoBehaviour
{
    public GameObject display;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        StartCoroutine(Countdown());
        display.SetActive(false);
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(2);
        display.SetActive(true);
        
    }
}
