using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class NPC_Dialogue_Arges : MonoBehaviour
{
    bool inChat = false; // να ενεργοποιειται/απενεργοποιειται οταν το βρισκομαστε εντος η εκτος του chat window αντιστοιχα
    bool inDialogue1 = true;
    bool inDialogueTopSubTree = false;
    bool inDialogueBotSubTree = false;
    bool inDialogueBotTopSubTree = false;
    bool inDialogueBotBotSubTree = false;
    bool inDialogueBotBotTopSubTree = false;

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
    public string bot2Response;
    public string bot2Response_gr;
    [Header("Dialogue1 BOT SubTree")]
    public string top3;
    public string top3_gr;
    public string top3Response;
    public string top3Response_gr;
    public string bot3;
    public string bot3_gr;
    public string bot3Response;
    public string bot3Response_gr;


    [Header("Dialogue1 BOT,TOP SubTree")]
    public string top4;
    public string top4_gr;
    public string bot4;
    public string bot4_gr;
    public string bot4Response;
    public string bot4Response_gr;
    [Header("Dialogue1 BOT,BOT SubTree")]
    public string top5;
    public string top5_gr;
    public string top5Response;
    public string top5Response_gr;
    public string bot5;
    public string bot5_gr;
    [Header("Dialogue1 BOT,BOT,TOP Subtree")]
    public string top6;
    public string top6_gr;
    public string bot6;
    public string bot6_gr;

    //for dialogue displaying purposes, as described at the else part of the Update function
    private bool talked_once = false;
    //to prevent the player from abusing his positive answer (only needed for answers which don't lead to new dialogue)
    private bool positive_1_counted = false;
    //same for negative ones, see gregor for more details
    private bool mistake_1 = false;
    private bool mistake_2 = false;
    [Header("Cursor handling")]
    public FirstPersonController Fps;
    [Header("Score handling")]
    //one for each instance of the score (with and without inventory)
    public Text points_1;
    public Text points_2;
    [Header("Sound handling")]
    public AudioSource correct_sound;
    public AudioSource false_sound;

    void Update()
    {
        if (CheckForChat_Arges.entrance_arges == true)
        {
            if (Umbrella_Mission.steropes_over == true && Umbrella_Mission.arges_over == false && Input.GetKeyDown("f"))
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
        inDialogueTopSubTree = false;
        inDialogueBotSubTree = false;
        inDialogueBotTopSubTree = false;
        inDialogueBotBotSubTree = false;
        inDialogueBotBotTopSubTree = false;
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
        inDialogueBotTopSubTree = false;
        inDialogueBotBotSubTree = false;
        inDialogueBotBotTopSubTree = false;
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
        inDialogueBotTopSubTree = false;
        inDialogueBotBotSubTree = false;
        inDialogueBotBotTopSubTree = false;
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

    void loadDialogue1BotTopSubTree()
    {
        inChat = true;
        inDialogue1 = false;
        inDialogueTopSubTree = false;
        inDialogueBotSubTree = false;
        inDialogueBotTopSubTree = true;
        inDialogueBotBotSubTree = false;
        inDialogueBotBotTopSubTree = false;
        if (Language_Script.lang_gr == false)
        {
            topText.GetComponent<Text>().text = top4;
            botText.GetComponent<Text>().text = bot4;
        }
        else
        {
            topText_gr.GetComponent<Text>().text = top4_gr;
            botText_gr.GetComponent<Text>().text = bot4_gr;
        }
    }

    void loadDialogue1BotBotSubTree()
    {
        inChat = true;
        inDialogue1 = false;
        inDialogueTopSubTree = false;
        inDialogueBotSubTree = false;
        inDialogueBotTopSubTree = false;
        inDialogueBotBotSubTree = true;
        inDialogueBotBotTopSubTree = false;
        if (Language_Script.lang_gr == false)
        {
            topText.GetComponent<Text>().text = top5;
            botText.GetComponent<Text>().text = bot5;
        }
        else
        {
            topText_gr.GetComponent<Text>().text = top5_gr;
            botText_gr.GetComponent<Text>().text = bot5_gr;
        }
    }

    void loadDialogue1BotBotTopSubTree()
    {
        inChat = true;
        inDialogue1 = false;
        inDialogueTopSubTree = false;
        inDialogueBotSubTree = false;
        inDialogueBotTopSubTree = false;
        inDialogueBotBotSubTree = false;
        inDialogueBotBotTopSubTree = true;
        if (Language_Script.lang_gr == false)
        {
            topText.GetComponent<Text>().text = top6;
            botText.GetComponent<Text>().text = "";
        }
        else
        {
            topText_gr.GetComponent<Text>().text = top6_gr;
            botText_gr.GetComponent<Text>().text = "";
        }
        Umbrella_Mission.arges_over = true;
        Umbrella_Mission.umbrella_mission_over = true;
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
        }
        else if (inDialogueTopSubTree)
        {
            //score
            if (talked_once == false && positive_1_counted == false)
            {
                Score_Script.score = Score_Script.score + 6; //6 of Odysseus's men were eaten by Polyphemus
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                correct_sound.Play();
                positive_1_counted = true;
            }
        }
        else if (inDialogueBotSubTree)
        {
            if (Language_Script.lang_gr == false)
            {
                chatText.GetComponent<Text>().text = top3Response;
            }
            else
            {
                chatText_gr.GetComponent<Text>().text = top3Response_gr;
            }
            loadDialogue1BotTopSubTree();
        }
        else if (inDialogueBotTopSubTree)
        {
            //score
            if (talked_once == false && mistake_1 == false)
            {
                Score_Script.score = Score_Script.score - 100;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                false_sound.Play();
                mistake_1 = true;
            }
        }
        else if (inDialogueBotBotSubTree)
        {
            if (Language_Script.lang_gr == false)
            {
                chatText.GetComponent<Text>().text = top5Response;
            }
            else
            {
                chatText_gr.GetComponent<Text>().text = top5Response_gr;
            }
            loadDialogue1BotBotTopSubTree();
            //score
            if (talked_once == false)
            {
                Score_Script.score = Score_Script.score + 300;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                correct_sound.Play();
            }
        }
        else if (inDialogueBotBotTopSubTree)
        {
            CloseDialogue();
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
        }
        else if (inDialogueTopSubTree)
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
        }
        else if (inDialogueBotSubTree)
        {
            if (Language_Script.lang_gr == false)
            {
                chatText.GetComponent<Text>().text = bot3Response;
            }
            else
            {
                chatText_gr.GetComponent<Text>().text = bot3Response_gr;
            }
            loadDialogue1BotBotSubTree();
        }
        else if (inDialogueBotBotSubTree)
        {
            //score
            if (talked_once == false && mistake_2 == false)
            {
                Score_Script.score = Score_Script.score - 200;
                points_1.text = "Score:" + (Score_Script.score).ToString();
                points_2.text = "Score:" + (Score_Script.score).ToString();
                false_sound.Play();
                mistake_2 = true;
            }
        }
        else if (inDialogueBotTopSubTree)
        {
            if (Language_Script.lang_gr == false)
            {
                chatText.GetComponent<Text>().text = bot4Response;
            }
            else
            {
                chatText_gr.GetComponent<Text>().text = bot4Response_gr;
            }
            loadDialogue1BotBotSubTree();
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
