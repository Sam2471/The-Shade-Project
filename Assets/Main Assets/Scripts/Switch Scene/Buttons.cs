using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Buttons : MonoBehaviour
{
    public static bool hasstarted = false;

    private void Start()
    {
        hasstarted = false;
    }
    public void ButtonStart()
    {
        hasstarted = true;
        SceneManager.LoadScene(1);
    }

    public void ButtonQuit()
    {
        Application.Quit();
    }
}
