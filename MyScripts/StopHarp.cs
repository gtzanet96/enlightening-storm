using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopHarp : MonoBehaviour
{
    public AudioSource myAudio;
    private bool audio_stopped = false;
    private bool entrance = false;

    private void Update()
    {
        if (myAudio.isPlaying && entrance == true)
        {
            myAudio.Stop();
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance = true;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance = false;
        }

    }
}
