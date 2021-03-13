using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    public Text TimeText;

    [SerializeField]
    public static float timeRemaining;
    
    void Start()
    {
        TimeText.text = "Time Remaining: " + Data.timeLimit;
        timeRemaining = Data.timeLimit;
    }

    void Update() {
        timeRemaining = timeRemaining - Time.deltaTime;
        TimeText.text = "Time Remaining: " + timeRemaining.ToString("F2");
        if (timeRemaining <= 0) {
            SceneManager.LoadScene("Credits");
        }
    }
}
