using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain_Stop : MonoBehaviour
{
    public GameObject rain3;
    public GameObject wind_sound;
    public GameObject rain_cave_sound;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            Rain_Start.rain_start = false;
            wind_sound.GetComponent<AudioSource>().volume = 0.2f;
            if (Rain_Start.rain_begin == true)
            {
                rain3.SetActive(true);
                rain_cave_sound.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Rain_Start.rain_begin == true)
            {
                Rain_Start.rain_start = true;
            }
            wind_sound.GetComponent<AudioSource>().volume = 0.4f;
            rain_cave_sound.SetActive(false);
        }
    }
}
