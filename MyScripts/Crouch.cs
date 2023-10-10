using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public static bool isCrouched = false;
    public GameObject fpvController;
    public GameObject wind_sound;
    public GameObject thunder_sound;
    public GameObject rain_simple_sound;
    public GameObject lightning_strike_sound;

    // Update is called once per frame
    void Update()
    {
        //is the crouch button being held?
        if (Input.GetKey("c"))
        {
            if (!isCrouched)
                crouch();

        }
        else
        {
            if (isCrouched)
            {
                //if there isn't and obstance above him, like a cave for example
                if (tObstacleScript.tObstacle == false)
                {
                    stand();
                }
            }
        }
    }
    private void crouch()
    {
        CharacterController controller = GetComponent<CharacterController>();

        controller.height /= 10;
        isCrouched = true;
        //if umbrella is closed, then the player supposedly covers his ears and the sounds get lower
        if (Umbrella_Use.umbrella_open == false)
        {
            wind_sound.GetComponent<AudioSource>().volume = 0.2f;
            thunder_sound.GetComponent<AudioSource>().volume = 0.3f;
            rain_simple_sound.GetComponent<AudioSource>().volume = 0.4f;
            lightning_strike_sound.GetComponent<AudioSource>().volume = 0.35f;
        }
    }

    private void stand()
    {
        CharacterController controller = GetComponent<CharacterController>();

        fpvController = GameObject.FindWithTag("Player");

        Vector3 vec = fpvController.transform.position;
        vec.y += controller.height / 10;
        controller.height *= 10;

        isCrouched = false;
        wind_sound.GetComponent<AudioSource>().volume = 0.4f;
        thunder_sound.GetComponent<AudioSource>().volume = 0.85f;
        rain_simple_sound.GetComponent<AudioSource>().volume = 0.85f;
        lightning_strike_sound.GetComponent<AudioSource>().volume = 1f;
    }
}
