using UnityEngine;

public class ActivateObjectAfterDelay : MonoBehaviour
{
    [SerializeField] private float delayTime;
    [SerializeField] private float time;

    [SerializeField] GameObject text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = delayTime;
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            text.SetActive(true);
        }
    }
}
