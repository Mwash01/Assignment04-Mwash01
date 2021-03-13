using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data : MonoBehaviour
{
    [SerializeField]
    public static string playerName;
    [SerializeField]
    public static int scoreNum;
    [SerializeField]
    public static int playerLives = 1;
    [SerializeField]
    public static int totalLives = 1;
    [SerializeField]
    public static float rotatorSpeed = 50f;
    [SerializeField]
    public static float fireSpeed = 10f;
    [SerializeField]
    public static float timeLimit = 15f;

    public static bool music = true;

    public InputField userInput;
    public Dropdown Lives;
    public Dropdown Time;
    public Slider RotatorSlider;
    public Slider FireSlider;
    public Toggle MusicToggle;

    void Start() {
        userInput.GetComponent<InputField>().text = PlayerPrefs.GetString("Name");
        Lives.GetComponent<Dropdown>().value = PlayerPrefs.GetInt("Lives");
        Time.GetComponent<Dropdown>().value = PlayerPrefs.GetInt("Time");
        RotatorSlider.value = PlayerPrefs.GetFloat("Rotator");
        FireSlider.value = PlayerPrefs.GetFloat("Fire");

        if (!PlayerPrefs.HasKey("Music")) {
            PlayerPrefs.SetInt("Music", 1);
            MusicToggle.isOn = true;
        }
        else {
            if (PlayerPrefs.GetInt("Music") == 0) {
                MusicToggle.isOn = false;
            }
            else {
                MusicToggle.isOn = true;
            }
        }
    }

    public void InputName() {
        playerName = userInput.text;
        PlayerPrefs.SetString("Name", playerName);
    }

    public void ChangeRotationSpeed() {
        rotatorSpeed = RotatorSlider.value;
        PlayerPrefs.SetFloat("Rotator", rotatorSpeed);
    }

    public void ChangeFiringSpeed() {
        fireSpeed = FireSlider.value;
        PlayerPrefs.SetFloat("Fire", fireSpeed);
    }

    public void ChangeLives() {
        switch(Lives.value) {
            case 0:
                playerLives = 1;
                totalLives = 1;
                PlayerPrefs.SetInt("Lives", Lives.value);
                break;
            case 1:
                playerLives = 3;
                totalLives = 3;
                PlayerPrefs.SetInt("Lives", Lives.value);
                break;
            case 2:
                playerLives = 5;
                totalLives = 5;
                PlayerPrefs.SetInt("Lives", Lives.value);
                break;
        }
    }

    public void ChangeTimer() {
        switch (Time.value) {
            case 0:
                timeLimit = 15f;
                PlayerPrefs.SetInt("Time", Time.value);
                break;
            case 1:
                timeLimit = 30f;
                PlayerPrefs.SetInt("Time", Time.value);
                break;
            case 2:
                timeLimit = 45f;
                PlayerPrefs.SetInt("Time", Time.value);
                break;
        }
    }

    public void ToggleMusic() {
        if (MusicToggle.isOn) {
            PlayerPrefs.SetInt("Music", 1);
            music = true;
        }
        if (!MusicToggle.isOn) {
            PlayerPrefs.SetInt("Music", 0);
            music = false;
        }
    }
}
