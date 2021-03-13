using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsData : MonoBehaviour
{
    public Text Score;
    public Text Lives;
    public Text Name;

    void Start()
    {
        Score.text = "Score: " + Data.scoreNum.ToString();
        Lives.text = "Total Lives: " + Data.totalLives.ToString();
        Name.text = "Name: " + Data.playerName;
    }

}
