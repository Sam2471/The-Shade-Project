using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadend : MonoBehaviour
{
    public GameObject controller;
    private void OnTriggerEnter(Collider other)
    {
        controller.SetActive(false);
        SceneManager.LoadScene(2);
    }
}
