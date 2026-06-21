using UnityEngine;

public class DisableObjects : MonoBehaviour
{
    public void GoToDifferentPrompt(GameObject differentPrompt)
    {
        differentPrompt.SetActive(true);
    }

    public void DisableCurrentPrompt(GameObject currentObject)
    {
        currentObject.SetActive(false);
    }
}
