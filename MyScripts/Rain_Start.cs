using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain_Start : MonoBehaviour
{
    public GameObject rain;
    public GameObject rain2;
    //if it's raining in the specific area that the player is located at a time
    public static bool rain_start = false;
    public GameObject rain_sound_simple;
    public GameObject rain_sound_umbrella;
    //rain in the mountain has started
    public static bool rain_begin = false;

    void Start()
    {
        rain_start = false;
        rain_begin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (rain_start == true)
        {
            rain.SetActive(true);
            rain2.SetActive(true);
            if (Umbrella_Use.umbrella_open == false)
            {
                rain_sound_simple.SetActive(true);
                rain_sound_umbrella.SetActive(false);
            }
            else
            {
                rain_sound_simple.SetActive(false);
                rain_sound_umbrella.SetActive(true);
            }
        } else
        {
            rain.SetActive(false);
            rain2.SetActive(false);
            rain_sound_simple.SetActive(false);
            rain_sound_umbrella.SetActive(false);
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            rain_begin = true;
            rain_start = true;
        }
    }
}
