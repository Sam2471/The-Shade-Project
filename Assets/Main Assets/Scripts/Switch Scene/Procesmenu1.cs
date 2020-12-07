using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procesmenu1 : MonoBehaviour
{
    public GameObject display;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
        display.SetActive(false);
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(1);
        display.SetActive(true);

    }


}
