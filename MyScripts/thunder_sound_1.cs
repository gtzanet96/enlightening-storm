using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thunder_sound_1 : MonoBehaviour
{
    AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        myAudio.PlayDelayed(3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
