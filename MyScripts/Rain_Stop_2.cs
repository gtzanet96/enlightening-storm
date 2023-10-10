using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain_Stop_2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //stop the rain
            Rain_Start.rain_start = false;
        }
    }
}
