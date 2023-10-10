using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Jarmusch : MonoBehaviour
{
    public static bool entrance_jarmusch = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_jarmusch = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_jarmusch = true;
            light.SetActive(true);
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_jarmusch = false;
            light.SetActive(false);
        }
    }
}
