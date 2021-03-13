using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;

    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;

    public void EndGame() {
        if(gameHasEnded) {
            return;
        }
        rotator.enabled = false;
        spawner.enabled = false;
        Data.scoreNum--;

        animator.SetTrigger("EndGame");

        gameHasEnded = true;
    }

    public void RestartGame() {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Data.playerLives--;
        if(Data.playerLives == 0) {
            SceneManager.LoadScene("Credits");
        }
        else {
            spawner.enabled = true;
            rotator.enabled = true;
            gameHasEnded = false;
        }
    }
}
