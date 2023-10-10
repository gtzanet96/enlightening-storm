using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Brontes : MonoBehaviour
{
    public static bool entrance_brontes = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_brontes = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && Umbrella_Mission.umbrella_mission_start == true && Umbrella_Mission.brontes_over == false)
        {
            entrance_brontes = true;
            light.SetActive(true);
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_brontes = false;
            light.SetActive(false);
        }

    }
}
