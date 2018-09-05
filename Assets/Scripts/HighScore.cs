using UnityEngine;

public class HighScore : MonoBehaviour
{

    public void RollHighScore1(int number)
    {
        if (number < PlayerPrefs.GetInt("HighScore33", 99999))
        {
            PlayerPrefs.SetInt("HighScore33", number);
        }

    }
    public void RollHighScore2(int number)
    {
        if (number < PlayerPrefs.GetInt("HighScore44", 99999))
        {
            PlayerPrefs.SetInt("HighScore44", number);
        }

    }
    public void RollHighScore3(int number)
    {
        if (number < PlayerPrefs.GetInt("HighScore55", 99999))
        {
            PlayerPrefs.SetInt("HighScore55", number);
        }

    }


}
