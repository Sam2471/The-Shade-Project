using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procesmenu : MonoBehaviour
{
    public GameObject display;

    public AudioSource menusource;
    public AudioClip menumusic;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        StartCoroutine(Countdown());
        display.SetActive(false);
    }

    private void Update()
    {
        if (Buttons.hasstarted == true)
        {
            menusource.Stop();
        }
    }

    IEnumerator Countdown()
    {
        yield return new WaitForSeconds(2);
        menusource.Play();
        display.SetActive(true);
        
    }
}
