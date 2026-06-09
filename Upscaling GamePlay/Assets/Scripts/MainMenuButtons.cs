using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void QuitGame()
    {
        QuitGame();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
