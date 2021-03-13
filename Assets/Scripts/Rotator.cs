using UnityEngine;

public class Rotator : MonoBehaviour
{
    //public float speed = 100f;
    public AudioSource Audio;
    private void Start() {
        if (Data.music) {
            Audio.enabled = true;
        }
        else {
            Audio.enabled = false;
        }
    }

    void Update() {
        transform.Rotate(0f, 0f, Data.rotatorSpeed * Time.deltaTime);

    }
}
