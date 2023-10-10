using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForChat_Iguana_7 : MonoBehaviour
{
    public static bool entrance_tower = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;
    private bool entered_once = false;
    public AudioSource myAudio;

    void Start()
    {
        entrance_tower = false;
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_tower = true;
            light.SetActive(true);
            if (entered_once == false)
            {
                myAudio.Play();
                //score
                Score_Script.score = Score_Script.score - 300;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                entered_once = true;
            }
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_tower = false;
            light.SetActive(false);
        }
    }
}
