using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Alvis : MonoBehaviour
{
    public static bool entrance_alvis = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_alvis = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_alvis = true;
            light.SetActive(true);
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_alvis = false;
            light.SetActive(false);
        }

    }
}
