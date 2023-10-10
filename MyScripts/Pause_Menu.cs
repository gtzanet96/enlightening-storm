using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause_Menu : MonoBehaviour {

	public GameObject PauseUI;
	public static bool GameisPaused;
    public AudioSource pause_on;
    public AudioSource pause_off;

    void Start () {
        GameisPaused = false;
    }

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
            if (GameisPaused)
            {
                Resume(); 
                //placing this here because for some reason it can't cooperate with the audio source im playing from the pausecanvas continue button...
                pause_off.Play();
            }
            else
                Pause();
		} 
	}

	public void Pause()
	{
        pause_on.Play();
        PauseUI.SetActive(true);
		Time.timeScale = 0f;
		GameisPaused = true;
	}

	public void Resume()
	{
        PauseUI.SetActive(false);
		Time.timeScale = 1f;
		GameisPaused = false;
    }
}
