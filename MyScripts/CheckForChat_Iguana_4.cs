using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Iguana_4 : MonoBehaviour
{
    public static bool entrance_myth1 = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_myth1 = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_myth1 = true;
            light.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_myth1 = false;
            light.SetActive(false);
        }
    }
}
