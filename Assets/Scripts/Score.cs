using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text ScoreText;

    void Start() {
        PinCount = 0;
    }
    void Update() {
        ScoreText.text = Data.scoreNum.ToString();
    }
}
