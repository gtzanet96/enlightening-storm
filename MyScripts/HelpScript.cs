using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : MonoBehaviour {

	public GameObject helpCanvas;
	public static bool helpActive;

    void Start()
    {
        helpActive = false;
    }

    void Update () {
		if (Input.GetKeyDown ("h")) {
			if (helpActive)
				Resume ();
			else
				Open ();
		}
	}

	public void Open()
	{
		helpCanvas.SetActive (true);
		helpActive = true;
	}

	public void Resume()
	{
		helpCanvas.SetActive (false);
		helpActive = false;
	}
}
