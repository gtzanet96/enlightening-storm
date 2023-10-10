using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class NPC_Dialogue_Iguana_4 : MonoBehaviour
{
    bool inChat = false; // να ενεργοποιειται/απενεργοποιειται οταν το βρισκομαστε εντος η εκτος του chat window αντιστοιχα
    bool inDialogue1 = true;
    bool inDialogueTopSubTree = false;
    bool inDialogueBotSubTree = false;
    public static bool iguana_4_spoke = false;

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
    public string top1Response;
    public string top1Response_gr;
    public string bot1;
    public string bot1_gr;
    public string bot1Response;
    public string bot1Response_gr;
    [Header("Dialogue1 TOP Subtree")]
    public string top2;
    public string top2_gr;
    public string bot2;
    public string bot2_gr;
    [Header("Dialogue1 BOT SubTree")]
    public string top3;
    public string top3_gr;
    public string bot3;
    public string bot3_gr;

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
    public AudioSource false_sound;

    void Start()
    {
        iguana_4_spoke = false;
    }

    void Update()
    {
        if (CheckForChat_Iguana_4.entrance_myth1 == true)
        {
            //the first time the player enters the collider, the dialogue will be displayed automatically
            if (iguana_4_spoke == false)
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
            else
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

    void loadDialogue1TopSubTree()
    {
        inChat = true;
        inDialogue1 = false;
        inDialogueTopSubTree = true;
        inDialogueBotSubTree = false;
        if (Language_Script.lang_gr == false)
        {
            topText.GetComponent<Text>().text = top2;
            botText.GetComponent<Text>().text = bot2;
        }
        else
        {
            topText_gr.GetComponent<Text>().text = top2_gr;
            botText_gr.GetComponent<Text>().text = bot2_gr;
        }
    }

    void loadDialogue1BotSubTree()
    {
        inChat = true;
        inDialogue1 = false;
        inDialogueTopSubTree = false;
        inDialogueBotSubTree = true;
        if (Language_Script.lang_gr == false)
        {
            topText.GetComponent<Text>().text = top3;
            botText.GetComponent<Text>().text = bot3;
        }
        else
        {
            topText_gr.GetComponent<Text>().text = top3_gr;
            botText_gr.GetComponent<Text>().text = bot3_gr;
        }
    }

    //ΚΟΥΜΠΙΑ
    //Εαν ο παικτης πατησει το ΠΑΝΩ κουμπι οποιαδηποτε στιγμη σε οποιοδηποτε παραθυρο
    public void Top()
    {
        if (inDialogue1)
        {
            if (Language_Script.lang_gr == false)
            {
                chatText.GetComponent<Text>().text = top1Response;
            }
            else
            {
                chatText_gr.GetComponent<Text>().text = top1Response_gr;
            }
            loadDialogue1TopSubTree();
            //score
            if (talked_once == false)
            {
                Score_Script.score = Score_Script.score - 300;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                false_sound.Play();
            }
        }
        else if (inDialogueTopSubTree)
        {
            //score
            if (talked_once == false)
            {
                Score_Script.score = Score_Script.score - 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                false_sound.Play();
            }
            CloseDialogue();
            iguana_4_spoke = true;
        }
        else if (inDialogueBotSubTree)
        {
            CloseDialogue();
            iguana_4_spoke = true;
        }
    }

    //Εαν ο παικτης πατησει το ΚΑΤΩ κουμπι οποιαδηποτε στιγμη σε οποιοδηποτε παραθυρο
    public void Bot()
    {
        if (inDialogue1)
        {
            if (Language_Script.lang_gr == false)
            {
                chatText.GetComponent<Text>().text = bot1Response;
            }
            else
            {
                chatText_gr.GetComponent<Text>().text = bot1Response_gr;
            }
            loadDialogue1BotSubTree();
            //tha prepei na dinei score to False, alla prosekse na mhn mporei na dinei false 2 fores. na mporei na to ksanapataei o paikths, alla oxi na prosmetratai 2 fores to score.
            //score
            if (talked_once == false)
            {
                Score_Script.score = Score_Script.score + 500;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                correct_sound.Play();
            }
        }
        else if (inDialogueTopSubTree)
        {
            iguana_4_spoke = true;
            //score
            if (talked_once == false)
            {
                Score_Script.score = Score_Script.score + 300;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                correct_sound.Play();
            }
            CloseDialogue();
        }
        else if (inDialogueBotSubTree)
        {
            CloseDialogue();
            iguana_4_spoke = true;
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
