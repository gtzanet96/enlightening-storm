using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Friend_1 : MonoBehaviour
{
    public static bool entrance_friend_1 = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public AudioSource myAudio;
    bool audio_played = false;

    void Start()
    {
        entrance_friend_1 = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (audio_played == false)
            {
                myAudio.Play();
                audio_played = true;
            }
            entrance_friend_1 = true;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_friend_1 = false;
        }

    }
}
