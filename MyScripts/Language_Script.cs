﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language_Script : MonoBehaviour
{
    public static bool lang_gr = false;
    public GameObject title;
    public GameObject title_gr;
    public GameObject mm_button1;
    public GameObject mm_button1_gr;
    public GameObject mm_button2;
    public GameObject mm_button2_gr;
    public GameObject mm_button3;
    public GameObject mm_button3_gr;
    public GameObject mm_button4;
    public GameObject mm_button4_gr;
    public GameObject mm_button5;
    public GameObject mm_button5_gr;
    public GameObject mm_button6;
    public GameObject mm_button6_gr;
    public GameObject audio_1;
    public GameObject audio_1_gr;
    public GameObject audio_2;
    public GameObject audio_2_gr;
    public GameObject audio_3;
    public GameObject audio_3_gr;
    public GameObject audio_4;
    public GameObject audio_4_gr;
    public GameObject controls_1;
    public GameObject controls_1_gr;
    public GameObject controls_2;
    public GameObject controls_2_gr;
    public GameObject controls_3;
    public GameObject controls_3_gr;
    public GameObject controls_4;
    public GameObject controls_4_gr;
    public GameObject controls_5;
    public GameObject controls_5_gr;
    public GameObject controls_6;
    public GameObject controls_6_gr;
    public GameObject controls_7;
    public GameObject controls_7_gr;
    public GameObject controls_8;
    public GameObject controls_8_gr;
    public GameObject controls_9;
    public GameObject controls_9_gr;
    public GameObject controls_10;
    public GameObject controls_10_gr;
    public GameObject lang_1;
    public GameObject lang_1_gr;
    public GameObject lang_2;
    public GameObject lang_2_gr;
    public GameObject help_1;
    public GameObject help_1_gr;
    public GameObject help_2;
    public GameObject help_2_gr;
    public GameObject help_3;
    public GameObject help_3_gr;

    // Update is called once per frame
    void Update()
    {
        if (lang_gr == false)
        {
            title_gr.SetActive(false);
            title.SetActive(true);
            mm_button1_gr.SetActive(false);
            mm_button2_gr.SetActive(false);
            mm_button3_gr.SetActive(false);
            mm_button4_gr.SetActive(false);
            mm_button5_gr.SetActive(false);
            mm_button6_gr.SetActive(false);
            mm_button1.SetActive(true);
            mm_button2.SetActive(true);
            mm_button3.SetActive(true);
            mm_button4.SetActive(true);
            mm_button5.SetActive(true);
            mm_button6.SetActive(true);
            audio_1_gr.SetActive(false);
            audio_2_gr.SetActive(false);
            audio_3_gr.SetActive(false);
            audio_4_gr.SetActive(false);
            audio_1.SetActive(true);
            audio_2.SetActive(true);
            audio_3.SetActive(true);
            audio_4.SetActive(true);
            controls_1_gr.SetActive(false);
            controls_2_gr.SetActive(false);
            controls_3_gr.SetActive(false);
            controls_4_gr.SetActive(false);
            controls_5_gr.SetActive(false);
            controls_6_gr.SetActive(false);
            controls_7_gr.SetActive(false);
            controls_8_gr.SetActive(false);
            controls_9_gr.SetActive(false);
            controls_10_gr.SetActive(false);
            controls_1.SetActive(true);
            controls_2.SetActive(true);
            controls_3.SetActive(true);
            controls_4.SetActive(true);
            controls_5.SetActive(true);
            controls_6.SetActive(true);
            controls_7.SetActive(true);
            controls_8.SetActive(true);
            controls_9.SetActive(true);
            controls_10.SetActive(true);
            lang_1_gr.SetActive(false);
            lang_2_gr.SetActive(false);
            lang_1.SetActive(true);
            lang_2.SetActive(true);
            help_1_gr.SetActive(false);
            help_2_gr.SetActive(false);
            help_3_gr.SetActive(false);
            help_1.SetActive(true);
            help_2.SetActive(true);
            help_3.SetActive(true);
        }
        else
        {
            title_gr.SetActive(true);
            title.SetActive(false);
            mm_button1_gr.SetActive(true);
            mm_button2_gr.SetActive(true);
            mm_button3_gr.SetActive(true);
            mm_button4_gr.SetActive(true);
            mm_button5_gr.SetActive(true);
            mm_button6_gr.SetActive(true);
            mm_button1.SetActive(false);
            mm_button2.SetActive(false);
            mm_button3.SetActive(false);
            mm_button4.SetActive(false);
            mm_button5.SetActive(false);
            mm_button6.SetActive(false);
            audio_1_gr.SetActive(true);
            audio_2_gr.SetActive(true);
            audio_3_gr.SetActive(true);
            audio_4_gr.SetActive(true);
            audio_1.SetActive(false);
            audio_2.SetActive(false);
            audio_3.SetActive(false);
            audio_4.SetActive(false);
            controls_1_gr.SetActive(true);
            controls_2_gr.SetActive(true);
            controls_3_gr.SetActive(true);
            controls_4_gr.SetActive(true);
            controls_5_gr.SetActive(true);
            controls_6_gr.SetActive(true);
            controls_7_gr.SetActive(true);
            controls_8_gr.SetActive(true);
            controls_9_gr.SetActive(true);
            controls_10_gr.SetActive(true);
            controls_1.SetActive(false);
            controls_2.SetActive(false);
            controls_3.SetActive(false);
            controls_4.SetActive(false);
            controls_5.SetActive(false);
            controls_6.SetActive(false);
            controls_7.SetActive(false);
            controls_8.SetActive(false);
            controls_9.SetActive(false);
            controls_10.SetActive(false);
            lang_1_gr.SetActive(true);
            lang_2_gr.SetActive(true);
            lang_1.SetActive(false);
            lang_2.SetActive(false);
            help_1_gr.SetActive(true);
            help_2_gr.SetActive(true);
            help_3_gr.SetActive(true);
            help_1.SetActive(false);
            help_2.SetActive(false);
            help_3.SetActive(false);
        }
    }
}