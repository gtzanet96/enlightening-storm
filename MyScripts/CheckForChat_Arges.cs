using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Arges : MonoBehaviour
{
    public static bool entrance_arges = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_arges = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && Umbrella_Mission.umbrella_mission_start == true && Umbrella_Mission.steropes_over == true && Umbrella_Mission.arges_over == false)
        {
            entrance_arges = true;
            light.SetActive(true);
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_arges = false;
            light.SetActive(false);
        }

    }
}
