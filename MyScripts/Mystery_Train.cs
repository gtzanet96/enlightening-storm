using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mystery_Train : MonoBehaviour
{
    public GameObject mystery_train;

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!mystery_train.activeSelf)
            {
                mystery_train.SetActive(true);
            }
        }
    }
}
