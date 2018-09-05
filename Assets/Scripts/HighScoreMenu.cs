using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreMenu : MonoBehaviour {


    public Text highScore1, highScore2, highScore3;
    void Start()
    {
        highScore1.text = "3x3 best score :" + "\n" + "\n" + "time: " + PlayerPrefs.GetInt("HighScore33", 99999).ToString() + " s";
        highScore2.text = "4x4 best score :" + "\n" + "\n" + "time: " + PlayerPrefs.GetInt("HighScore44", 99999).ToString() + " s";
        highScore3.text = "5x5 best score :" + "\n" + "\n" + "time: " + PlayerPrefs.GetInt("HighScore55", 99999).ToString() + " s";

    }
    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

}
