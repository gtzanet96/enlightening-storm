using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForChat_Trash : MonoBehaviour
{
    public static bool entrance_trash = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;
    public GameObject trash;
    public GameObject trash_sprite;
    public AudioSource myAudio;
    bool audio_played = false;
    public static bool trash_yes = false;
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;

    void Start()
    {
        entrance_trash = false;
    }

    void Update()
    {
        if (NPC_Dialogue_Friend_1.pack_things == true && trash_yes == false)
        {
            light.SetActive(true);
        }

        if (entrance_trash == true && NPC_Dialogue_Friend_1.pack_things == true)
        {
            if (Input.GetKeyDown("f") && trash_yes == false)
            {
                trash.SetActive(false);
                light.SetActive(false);
                if (audio_played == false)
                {
                    myAudio.Play();
                    audio_played = true;
                }
                trash_sprite.SetActive(true);
                trash_yes = true;
                //score
                Score_Script.score = Score_Script.score + 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_trash = true;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_trash = false;
        }
    }
}
