using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language_Victory : MonoBehaviour
{
    public GameObject victory1;
    public GameObject victory1_gr;
    public GameObject victory2;
    public GameObject victory2_gr;
    public GameObject victory3;
    public GameObject victory3_gr;
    public GameObject victory4;
    public GameObject victory4_gr;
    public GameObject victory5;
    public GameObject victory5_gr;
    public GameObject victory6;
    public GameObject victory6_gr;

    // Update is called once per frame
    void Awake()
    {
        if (Language_Script.lang_gr == false)
        {
            victory1_gr.SetActive(false);
            victory2_gr.SetActive(false);
            victory3_gr.SetActive(false);
            victory4_gr.SetActive(false);
            victory5_gr.SetActive(false);
            victory6_gr.SetActive(false);
            victory1.SetActive(true);
            victory2.SetActive(true);
            victory3.SetActive(true);
            victory4.SetActive(true);
            victory5.SetActive(true);
            victory6.SetActive(true);
        }
        else
        {
            victory1_gr.SetActive(true);
            victory2_gr.SetActive(true);
            victory3_gr.SetActive(true);
            victory4_gr.SetActive(true);
            victory5_gr.SetActive(true);
            victory6_gr.SetActive(true);
            victory1.SetActive(false);
            victory2.SetActive(false);
            victory3.SetActive(false);
            victory4.SetActive(false);
            victory5.SetActive(false);
            victory6.SetActive(false);
        }
    }
}
