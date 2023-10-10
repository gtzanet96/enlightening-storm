using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Iguana_5 : MonoBehaviour
{
    public static bool entrance_park = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_park = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_park = true;
            light.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_park = false;
            light.SetActive(false);
        }
    }
}
