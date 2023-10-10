using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckForChat_Pack_up : MonoBehaviour
{
    public static bool entrance_tent = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
    public GameObject light;
    public GameObject camping;
    public GameObject camping_sprite;
    public AudioSource myAudio;
    public GameObject help_canvas;
    bool audio_played = false;
    public static bool packed_up = false;
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;
    //variable for gui label style changes
    private GUIStyle guiStyle = new GUIStyle();

    void Start()
    {
        entrance_tent = false;
    }

    void Update()
    {
        if (NPC_Dialogue_Friend_1.pack_things == true && packed_up == false)
        {
            light.SetActive(true);
        }

        if (entrance_tent == true && NPC_Dialogue_Friend_1.pack_things == true)
        {
            if (Input.GetKeyDown("f") && packed_up == false)
            {
                camping.SetActive(false);
                light.SetActive(false);
                if (audio_played == false)
                {
                    myAudio.Play();
                    audio_played = true;
                }
                camping_sprite.SetActive(true);
                packed_up = true;
                //score
                Score_Script.score = Score_Script.score + 200;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                //show help canvas
                help_canvas.SetActive(true);
                HelpScript.helpActive = true;
            }
        }
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_tent = true;
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            entrance_tent = false;
        }
    }

    public void OnGUI()
    {
        useGUILayout = false; //prevents lag on build
        guiStyle.fontSize = 18; //changing the font size
        guiStyle.normal.textColor = Color.white; //color
        guiStyle.alignment = TextAnchor.UpperCenter; //alignment

        if (entrance_tent && NPC_Dialogue_Friend_1.pack_things == true && packed_up == false && Pause_Menu.GameisPaused == false)
        {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 100, Screen.width, 100), "Press 'F' to put your camping equipment on your backpack.", guiStyle);
            }
            else
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 100, Screen.width, 100), "Πατήστε 'F' για να τοποθετήσετε τη σκηνή και τον εξοπλισμό σας πίσω στο σακίδιο.", guiStyle);
            }
        }
    }
}
