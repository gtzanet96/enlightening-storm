using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language_Scene : MonoBehaviour
{
    //pause menu
    public GameObject pause_txt_1;
    public GameObject pause_txt_1_gr;
    public GameObject pause_txt_2;
    public GameObject pause_txt_2_gr;
    public GameObject pause_txt_3;
    public GameObject pause_txt_3_gr;
    //help menu
    public GameObject help_txt_1;
    public GameObject help_txt_1_gr;
    public GameObject help_txt_2;
    public GameObject help_txt_2_gr;
    public GameObject help_txt_3;
    public GameObject help_txt_3_gr;

    // Update is called once per frame
    void Awake()
    {
        //Language_Script.lang_gr = true;
        if (Language_Script.lang_gr == false)
        {
            pause_txt_1_gr.SetActive(false);
            pause_txt_2_gr.SetActive(false);
            pause_txt_3_gr.SetActive(false);
            pause_txt_1.SetActive(true);
            pause_txt_2.SetActive(true);
            pause_txt_3.SetActive(true);
            help_txt_1_gr.SetActive(false);
            help_txt_2_gr.SetActive(false);
            help_txt_3_gr.SetActive(false);
            help_txt_1.SetActive(true);
            help_txt_2.SetActive(true);
            help_txt_3.SetActive(true);
        }
        else
        {
            pause_txt_1.SetActive(false);
            pause_txt_2.SetActive(false);
            pause_txt_3.SetActive(false);
            pause_txt_1_gr.SetActive(true);
            pause_txt_2_gr.SetActive(true);
            pause_txt_3_gr.SetActive(true);
            help_txt_1.SetActive(false);
            help_txt_2.SetActive(false);
            help_txt_3.SetActive(false);
            help_txt_1_gr.SetActive(true);
            help_txt_2_gr.SetActive(true);
            help_txt_3_gr.SetActive(true);
        }
    }
}
