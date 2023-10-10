using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warn_Whales : MonoBehaviour
{
    private bool entrance_whales = false;
    public GameObject light;
    private bool whales_gone = false;
    public GameObject whale1;
    public GameObject whale2;
    public AudioSource myAudio;
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;

    void Update()
    {
        if (entrance_whales == true && whales_gone == false)
        {
            if (Input.GetKeyDown("f"))
            {
                Destroy(whale1);
                Destroy(whale2);
                Destroy(light);
                myAudio.Play();
                //score
                Score_Script.score = Score_Script.score + 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                whales_gone = true;
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_whales = true;
            if (whales_gone == false)
            {
                light.SetActive(true);
            }
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_whales = false;
            light.SetActive(false);
        }
    }
}
