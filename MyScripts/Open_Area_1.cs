using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Open_Area_1 : MonoBehaviour
{
    private static bool entrance_open_1 = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;
    public static bool dmg_crouch_done = false;
    public static bool dmg_umbrella_done = false;
    public AudioSource myAudio;
    //variable for gui label style changes
    private GUIStyle guiStyle = new GUIStyle();

    void Start()
    {
        entrance_open_1 = false;
        dmg_crouch_done = false;
        dmg_umbrella_done = false;
    }

    // Update is called once per frame
    void Update()
    {
        //punish not crouching
        if (entrance_open_1 == true && Crouch.isCrouched == false)
        {
            if (dmg_crouch_done == false)
            {
                myAudio.Play();
                //score
                Score_Script.score = Score_Script.score - 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                dmg_crouch_done = true;
            }
        }
        //punish leaving your umbrella open, and thus your ears uncovered and your height slightly increased
        if (entrance_open_1 == true && Umbrella_Use.umbrella_open == true)
        {
            if (dmg_umbrella_done == false)
            {
                myAudio.Play();
                //score
                Score_Script.score = Score_Script.score - 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                dmg_umbrella_done = true;
            }
        }

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_open_1 = true;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_open_1 = false;
        }

    }

    public void OnGUI()
    {
        useGUILayout = false; //prevents lag on build
        guiStyle.fontSize = 18; //changing the font size
        guiStyle.normal.textColor = Color.white; //color
        guiStyle.alignment = TextAnchor.UpperCenter; //alignment

        if (entrance_open_1 && Crouch.isCrouched == false && Pause_Menu.GameisPaused == false)
        {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 275, Screen.width, 100), "Please keep crouching until the end of the valley.", guiStyle);
            }
            else
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 275, Screen.width, 100), "Παρακαλώ μη σταματάτε να σκύβετε μέχρι το τέλος της κοιλάδας.", guiStyle);
            }
        }
        if (entrance_open_1 && Umbrella_Use.umbrella_open == true && Pause_Menu.GameisPaused == false)
        {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 - 285, Screen.width, 100), "Please close your umbrella.", guiStyle);
            }
            else
            {
                GUI.Label(new Rect(0, Screen.height / 2 - 285, Screen.width, 100), "Παρακαλώ κλείστε την ομπρέλα σας.", guiStyle);
            }
        }
    }
}
