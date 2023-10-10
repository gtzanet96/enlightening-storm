using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Umbrella_Use : MonoBehaviour
{
    public GameObject umbrella_use;
    public static bool umbrella_open = false;
    public AudioSource audioSource;
    public GameObject umbrella_icon;
    //note: the rain sound (simple/umbrella) is being managed inside the script of the rain_collider

    void Start()
    {
        umbrella_open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("u")) {
            if (Umbrella_Mission.umbrella_received == true && umbrella_open == false)
            {
                //display the umbrella object at the scene
                umbrella_use.SetActive(true);
                //variable to check if umbrella is open at any given time
                umbrella_open = true;
                //remove from inventory, so that it appears as it's being used
                umbrella_icon.SetActive(false);
                //play umbrella opening-closing sound
                audioSource.Play();
            }
            else if (Umbrella_Mission.umbrella_received == true && umbrella_open == true)
            {
                umbrella_use.SetActive(false);
                umbrella_open = false;
                audioSource.Play();
                umbrella_icon.SetActive(true);
            }
        }
    }
}
