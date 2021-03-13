using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public static Vector2 position;
    private bool isPinned = false;
    //public float speed = 20f;
    public Rigidbody2D rb;

    void Update() {
        if (!isPinned) {
            rb.MovePosition(rb.position + Vector2.up * Data.fireSpeed * Time.deltaTime);
        }
        position = gameObject.transform.position;
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Rotator") {
            transform.SetParent(col.transform);
            isPinned = true;
            //Score.PinCount++;
            Data.scoreNum++;
        }
        else if(col.tag == "Pin") {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
