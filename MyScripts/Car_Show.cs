using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Show : MonoBehaviour
{
    public GameObject light;
    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            light.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            light.SetActive(false);
        }
    }
}
