using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Iguana_8 : MonoBehaviour
{
    public static bool entrance_car = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light_gold;
    public GameObject light_red;

    void Start()
    {
        entrance_car = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_car = true;
            light_gold.SetActive(true);
            light_red.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_car = false;
            light_gold.SetActive(false);
            light_red.SetActive(true);
        }
    }
}
