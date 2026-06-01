using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{

    private float time;
    [SerializeField] private float gameTimer;
    [SerializeField] private TextMeshProUGUI timerText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time = gameTimer;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timerText.text = time.ToString("00");

        if (time <= 0 && GameManager.ssSprites.Count > 1)
        {
            SceneManager.LoadScene(2);
        }
        else if (time <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
