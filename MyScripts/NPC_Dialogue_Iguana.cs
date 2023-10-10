using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class NPC_Dialogue_Iguana : MonoBehaviour
{
    bool inChat = false; // να ενεργοποιειται/απενεργοποιειται οταν το βρισκομαστε εντος η εκτος του chat window αντιστοιχα
    bool inDialogue1 = true;
    public static bool iguana_spoke = false;

    [Header("Object")]
    public GameObject npcWindow;
    public Text chatText;
    public Text chatText_gr;
    public Text topText;
    public Text topText_gr;
    public Text botText;
    public Text botText_gr;
    [Header("All Possible Dialogue Options")]
    public string greeting;
    public string greeting_gr;
    [Header("Dialogue1")]
    public string top1;
    public string top1_gr;
    public string bot1;
    public string bot1_gr;

    //for dialogue displaying purposes, as described at the else part of the Update function
    private bool talked_once = false;
    [Header("Cursor handling")]
    public FirstPersonController Fps;
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;
    [Header("Sound handling")]
    public AudioSource correct_sound;

    void Start()
    {
        iguana_spoke = false;
    }

    void Update()
    {
        if (CheckForChat_Iguana_1.entrance_site == true)
        {   //the first time the player enters the collider, the dialogue will be displayed automatically
            if (iguana_spoke == false)
            {
                //δουλευει μονο αν εισαι εντος range και το chatWindow δεν ειναι ηδη ανοικτο
                if (!inChat)
                {
                    npcWindow.gameObject.SetActive(true);
                    if (Language_Script.lang_gr == false)
                    {
                        chatText.GetComponent<Text>().text = greeting;
                    }
                    else
                    {
                        chatText_gr.GetComponent<Text>().text = greeting_gr;
                    }
                    loadDialogue1();
                    Fps.m_MouseLook.SetCursorLock(false);
                    Fps.m_MouseLook.UpdateCursorLock();
                    Fps.m_MouseLook.XSensitivity = 0;
                    Fps.m_MouseLook.YSensitivity = 0;
                }
            } else
            {
                //if the dialogue 's already been shown once, the player will have to press F to see it again
                if (Input.GetKeyDown("f"))
                {
                    //δουλευει μονο αν εισαι εντος range και το chatWindow δεν ειναι ηδη ανοικτο
                    if (!inChat)
                    {
                        npcWindow.gameObject.SetActive(true);
                        if (Language_Script.lang_gr == false)
                        {
                            chatText.GetComponent<Text>().text = greeting;
                        }
                        else
                        {
                            chatText_gr.GetComponent<Text>().text = greeting_gr;
                        }
                        loadDialogue1();
                        Fps.m_MouseLook.SetCursorLock(false);
                        Fps.m_MouseLook.UpdateCursorLock();
                        Fps.m_MouseLook.XSensitivity = 0;
                        Fps.m_MouseLook.YSensitivity = 0;
                    }
                }
            }
        }
        else
        {
            /*you can skip the dialogue by leaving the NPC's area, but only if you 've already completed the dialogue once. That way, we prevent counting the score several times and skipping 
            the dialogue after unfavourable dialogue choices in order to retake it*/
            if (inChat && talked_once == true)
            {
                CloseDialogue();
            }
        }

    }

    //πρωτη σειρα μηνυματων
    void loadDialogue1()
    {
        inChat = true;
        inDialogue1 = true;
        if (Language_Script.lang_gr == false)
        {
            topText.GetComponent<Text>().text = top1;
            botText.GetComponent<Text>().text = bot1;
        }
        else
        {
            topText_gr.GetComponent<Text>().text = top1_gr;
            botText_gr.GetComponent<Text>().text = bot1_gr;
        }
    }

    //ΚΟΥΜΠΙΑ
    //Εαν ο παικτης πατησει το ΠΑΝΩ κουμπι οποιαδηποτε στιγμη σε οποιοδηποτε παραθυρο
    public void Top()
    {
        if (inDialogue1)
        {
            iguana_spoke = true;
            CloseDialogue();
        }
    }

    //Εαν ο παικτης πατησει το ΚΑΤΩ κουμπι οποιαδηποτε στιγμη σε οποιοδηποτε παραθυρο
    public void Bot()
    {
        if (inDialogue1)
        {
            iguana_spoke = true;
            //score
            if (talked_once == false)
            {
                Score_Script.score = Score_Script.score + 100;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                correct_sound.Play();
            }
            CloseDialogue();
        }
    }

    void CloseDialogue()
    {
        Fps.m_MouseLook.SetCursorLock(true);
        Fps.m_MouseLook.UpdateCursorLock();
        Fps.m_MouseLook.XSensitivity = 1;
        Fps.m_MouseLook.YSensitivity = 1;
        npcWindow.gameObject.SetActive(false);
        inChat = false;
        talked_once = true;
    }
}
