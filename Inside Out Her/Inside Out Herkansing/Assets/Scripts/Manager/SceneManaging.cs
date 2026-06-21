using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManaging : MonoBehaviour
{

    public void LoadNextScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
}
