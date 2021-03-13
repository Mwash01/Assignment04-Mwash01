using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool pause;
    public GameObject PauseMenu;

    void Start()
    {
        pause = false;
        PauseMenu = GameObject.Find("Canvas");
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            pause = !pause;
        }
        if (pause) {
            Time.timeScale = 0;
            PauseMenu.transform.GetChild(0).gameObject.SetActive(true);
        }
        else if (!pause) {
            Time.timeScale = 1;
            PauseMenu.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
