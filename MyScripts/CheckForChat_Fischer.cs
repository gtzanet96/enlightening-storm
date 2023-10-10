using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Fischer : MonoBehaviour
{
    public static bool entrance_fischer = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_fischer = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_fischer = true;
            light.SetActive(true);
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_fischer = false;
            light.SetActive(false);
        }

    }
}
