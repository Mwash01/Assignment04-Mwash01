using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartNewGame() {
        SceneManager.LoadScene("Main Scene");
    }

    public void RestartGame() {
        Data.playerLives = 1;
        Data.totalLives = 1;
        Data.scoreNum = 0;
        SceneManager.LoadScene("IntroScene");
    }

    public void QuitGame() {
        Application.Quit();
        UnityEditor.EditorApplication.ExitPlaymode();
    }

    public void Credits() {
        SceneManager.LoadScene("Credits");
    }
}
