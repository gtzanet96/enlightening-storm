using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Umbrella_Mission : MonoBehaviour
{
    public static bool umbrella_mission_start = false;
    public static bool brontes_start = false;
    public static bool brontes_over = false;
    public static bool steropes_start = false;
    public static bool steropes_over = false;
    public static bool arges_start = false;
    public static bool arges_over = false;
    public static bool umbrella_mission_over = false;
    public static bool umbrella_received = false;
    private bool enter;
    public GameObject light_red;
    public GameObject light_brontes_area;
    public GameObject light_brontes_body;
    public GameObject light_steropes_area;
    public GameObject light_steropes_body;
    public GameObject light_arges_area;
    public GameObject light_arges_body;
    public GameObject light_green;
    public GameObject umbrella_icon;
    public GameObject umbrella;
    public GameObject harp_music;
    public AudioSource myAudio;
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;
    //variable for gui label style changes
    private GUIStyle guiStyle = new GUIStyle();

    void Start()
    {
        umbrella_mission_start = false;
        brontes_start = false;
        brontes_over = false;
        steropes_start = false;
        steropes_over = false;
        arges_start = false;
        arges_over = false;
        umbrella_mission_over = false;
        umbrella_received = false;
    }

    void Update()
    {
        if (enter)
        {
            //if mission starts
            if (umbrella_mission_start == false && Input.GetKeyDown("f"))
            {
                umbrella_mission_start = true;
                //Destroy(gameObject, 0.5f);
                brontes_start = true;
            }

            if (umbrella_mission_over == true && umbrella_received == false && Input.GetKeyDown("f"))
            {
                //score
                Score_Script.score = Score_Script.score + 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                myAudio.Play();
                umbrella_icon.SetActive(true);
                umbrella_received = true;
                Destroy(umbrella, 0.5f);
            }
        }
        //brontes light
        if (brontes_start && brontes_over == false)
        {
            light_brontes_area.SetActive(true);
        }
        else
        {
            if (light_brontes_area == true)
            {
                light_brontes_area.SetActive(false);
                light_brontes_body.SetActive(false);
            }
        }
        //steropes light
        if (steropes_start && steropes_over == false)
        {
            light_steropes_area.SetActive(true);
        }
        else
        {
            if (light_steropes_area == true)
            {
                light_steropes_area.SetActive(false);
                light_steropes_body.SetActive(false);
            }
        }
        //arges light
        if (arges_start && arges_over == false)
        {
            light_arges_area.SetActive(true);
        }
        else
        {
            if (light_arges_area == true)
            {
                light_arges_area.SetActive(false);
                light_arges_body.SetActive(false);
            }
        }
        //umbrella ready light
        if (umbrella_mission_over == true && umbrella_received == false)
        {
            light_red.SetActive(false);
            light_green.SetActive(true);
        }
        else
        {
            if (light_green.activeSelf)
            {
                light_green.SetActive(false);
                harp_music.SetActive(false);
            }
        }
    }
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            enter = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enter = false;
        }
    }

    public void OnGUI()
    {
        useGUILayout = false; //prevents lag on build
        guiStyle.fontSize = 18; //changing the font size
        guiStyle.normal.textColor = Color.white; //color
        guiStyle.alignment = TextAnchor.UpperCenter; //alignment

        if (enter && umbrella_mission_start == false && Pause_Menu.GameisPaused == false)
        {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 - 25, Screen.width, 100), "Press 'F' to start the mission. Your reward is an umbrella.", guiStyle);
            }
            else 
            {
                GUI.Label(new Rect(0, Screen.height / 2 - 25, Screen.width, 100), "Πατήστε 'F' για να ξεκινήσετε την αποστολή. Η ανταμοιβή σας είναι μία ομπρέλα.", guiStyle);
            }
        }
        if (enter && umbrella_mission_over == true && umbrella_received == false && Pause_Menu.GameisPaused == false) {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 100, Screen.width, 100), "You completed the challenge. Press 'F' to pick up the umbrella and 'U' to use it.", guiStyle);
            }
            else
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 100, Screen.width, 100), "Ολοκληρώσατε την αποστολή. Πατήστε 'F' για να πάρετε την ομπρέλα και 'U' για να την χρησιμοποιήσετε.", guiStyle);
            }
        }
    }
}
