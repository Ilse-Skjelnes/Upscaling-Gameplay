using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeToBlack : MonoBehaviour
{
    public GameObject gO;
    public Image img;
    public float colorAlpha;
    public float addedAlpha;

    public int cutscene;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        img.color = new Color(0, 0, 0, colorAlpha);

        if (colorAlpha >= 1)
        {
            colorAlpha = 0;
            GameManager.cutsceneIndex = cutscene;
            GameManager.Instance.danceMusic.SetActive(false);
            SceneManager.LoadScene(2);
        }
    }

    public void ChangeAlpha()
    {
        colorAlpha += addedAlpha;
    }
}
