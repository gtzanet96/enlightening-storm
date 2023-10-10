using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Iguana_2 : MonoBehaviour
{
    public static bool entrance_thunder = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_thunder = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_thunder = true;
            light.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_thunder = false;
            light.SetActive(false);
        }
    }
}
