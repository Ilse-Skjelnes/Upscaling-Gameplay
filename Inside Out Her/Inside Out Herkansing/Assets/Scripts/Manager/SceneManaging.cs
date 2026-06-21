using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{

    public void LoadNextScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Additive);
    }



    public void QuitTheGame()
    {
        Application.Quit();
    }
    
}
