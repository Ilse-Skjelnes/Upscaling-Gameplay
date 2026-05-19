using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeChoice : MonoBehaviour
{
    private GameObject nextChoice;
    public void Choose(GameObject nextChoice)
    {
        nextChoice.SetActive(true);
    }

    public void FinalChoice(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
