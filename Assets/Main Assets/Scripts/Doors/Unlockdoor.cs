using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockdoor : MonoBehaviour
{
    public GameObject table;
    public GameObject alttable;

    private void Start()
    {
        alttable.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        table.SetActive(false);
        alttable.SetActive(true);

    }
}
