using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alvis_song : MonoBehaviour
{
    public GameObject new_audio;
    bool new_audio_played = false;
    public GameObject prev_audio;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (new_audio_played == false)
            {
                new_audio.SetActive(true);
                new_audio_played = true;
                prev_audio.SetActive(false);
            }
        }

    }
}
