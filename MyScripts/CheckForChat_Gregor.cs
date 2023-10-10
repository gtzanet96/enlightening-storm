using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForChat_Gregor : MonoBehaviour {

	public static bool entrance_gregor = false; //να ενεργοποιειται οταν ο παικτης ειναι μεσα στο range του NPC
	public GameObject light;
    Animator animator;
    public static bool gregor_awake = false;
    //variable for gui label style changes
    private GUIStyle guiStyle = new GUIStyle();

    void Start () {
        animator = GetComponent<Animator>();
        entrance_gregor = false;
        gregor_awake = false;
    }

    void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
            entrance_gregor = true;
			light.SetActive (true);
            gregor_awake = true;
        } 

	}

	void OnTriggerExit (Collider col)
	{
		if (col.gameObject.tag == "Player")
		{
            entrance_gregor = false;
			light.SetActive (false);
		} 

	}

    public void OnGUI()
    {
        useGUILayout = false; //prevents lag on build
        guiStyle.fontSize = 18; //changing the font size
        guiStyle.normal.textColor = Color.white; //color
        guiStyle.alignment = TextAnchor.UpperCenter; //alignment

        if (entrance_gregor && NPC_Dialogue_Gregor.greg_dialogue_started == false && Pause_Menu.GameisPaused == false)
        {
            if (Language_Script.lang_gr == false)
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 150, Screen.width, 100), "Press F to interact with other characters.", guiStyle);
            }
            else
            {
                GUI.Label(new Rect(0, Screen.height / 2 + 150, Screen.width, 100), "Πατήστε F για να αλληλεπιδράσετε με τους χαρακτήρες του παιχνιδιού.", guiStyle);
            }
        }
    }
}
