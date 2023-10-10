using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_UI_Script : MonoBehaviour
{
    public GameObject score_1;
    public GameObject score_2;

    // Update is called once per frame
    void Update()
    {
        if(Inventory_script.inventoryActive == true)
        {
            score_1.SetActive(true);
            score_2.SetActive(false);
        }
        else
        {
            score_2.SetActive(true);
            score_1.SetActive(false);
        }
    }
}
