using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public Text fscore;
	public Text HighScore;
    public Text fscore_gr;
    public Text HighScore_gr;
    public GameObject score1;
    public GameObject score1_gr;
    public GameObject score2;
    public GameObject score2_gr;
    private int highscore;

    void Start()
    {
        //check if this is a highscore
        if (Score_Script.score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score_Script.score);
        }

        //if (Score_Script.score > PlayerPrefs.GetInt("HighScore_gr", 0))
        // {
        //    PlayerPrefs.SetInt("HighScore_gr", Score_Script.score);
        // }

        highscore = PlayerPrefs.GetInt("HighScore", 0);

        //show score and highscore values in their respective texts
        if (Language_Script.lang_gr == false)
        {
            score1_gr.SetActive(false);
            score2_gr.SetActive(false);
            score1.SetActive(true);
            score2.SetActive(true);
            fscore.text = "Score: " + Score_Script.score.ToString();
            HighScore.text = "High Score: " + highscore;
        }
        else
        {
            score1_gr.SetActive(true);
            score2_gr.SetActive(true);
            score1.SetActive(false);
            score2.SetActive(false);
            fscore_gr.text = "Βαθμολογία: " + Score_Script.score.ToString();
            HighScore_gr.text = "Ρεκόρ: " + highscore;
        }

        //to delete player data from the editor (or from the build too)
        //PlayerPrefs.DeleteAll();
    }
}
