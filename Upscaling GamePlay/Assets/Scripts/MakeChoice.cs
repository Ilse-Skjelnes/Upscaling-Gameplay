using Unity.Properties;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeChoice : MonoBehaviour
{
    private GameObject nextChoice;
    public int choiceIndex;
    public void Choose(GameObject nextChoice)
    {
        nextChoice.SetActive(true);
    }

    public void FinalChoice(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void ChooseCutscene(int cutSceneIndex)
    {
        GameManager.cutsceneIndex= cutSceneIndex;
    }

    public void DisableChoice(GameObject thisChoice)
    {
        thisChoice.SetActive(false);
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
