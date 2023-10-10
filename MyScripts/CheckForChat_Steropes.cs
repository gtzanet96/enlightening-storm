using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Steropes : MonoBehaviour
{
    public static bool entrance_steropes = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;

    void Start()
    {
        entrance_steropes = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && Umbrella_Mission.umbrella_mission_start == true && Umbrella_Mission.brontes_over == true && Umbrella_Mission.steropes_over == false)
        {
            entrance_steropes = true;
            light.SetActive(true);
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_steropes = false;
            light.SetActive(false);
        }

    }
}
