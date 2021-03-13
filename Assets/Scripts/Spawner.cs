using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;
    public Text LivesText;
    public Text NameField;

    void Start() {
        NameField.text = Data.playerName;
        
    }

    void Update() {
        LivesText.text = "Lives: " + Data.playerLives.ToString();
        if (Input.GetButtonDown("Fire1")) {
            SpawnPin();
        }
    }

    void SpawnPin() {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
