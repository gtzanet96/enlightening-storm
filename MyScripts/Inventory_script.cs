using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_script : MonoBehaviour
{
    public GameObject inventoryCanvas;
    public static bool inventoryActive = true;

    void Start()
    {
        inventoryActive = true;
    }

    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            if (inventoryActive)
                Resume();
            else
                Open();
        }
    }

    public void Open()
    {
        inventoryCanvas.SetActive(true);
        inventoryActive = true;
    }

    public void Resume()
    {
        inventoryCanvas.SetActive(false);
        inventoryActive = false;
    }
}
