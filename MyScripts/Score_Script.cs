using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour {

    //one for each instance of the score (with and without inventory)
	public Text points_1;
    public Text points_2;

    public static int score = 0;
	public static bool playing = true;

	public void Start () {
		score = 0;
		playing = true;
	}
}
