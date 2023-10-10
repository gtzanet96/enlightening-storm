using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harp : MonoBehaviour
{
    public AudioSource myAudio;
    bool audio_played = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //myAudio = GetComponent<AudioSource>();
            if (audio_played == false)
            {
                myAudio.Play();
                audio_played = true;
            }
        }

    }
}
