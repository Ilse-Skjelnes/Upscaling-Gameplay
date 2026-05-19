using UnityEngine;

public class DisableChoice : MonoBehaviour
{
    public GameObject previousChoise;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        previousChoise.SetActive(false);
    }

}
