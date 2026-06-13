using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndScreen : MonoBehaviour
{
    public int sceneIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x == 3)
        {
            GameManager.cutsceneIndex = sceneIndex;
            SceneManager.LoadScene(2);
        }
    }
}
