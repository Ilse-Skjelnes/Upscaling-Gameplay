using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowScreenShots : MonoBehaviour
{


    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject screenShot;

    [SerializeField] private TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(GameManager.ssSprites.Count);
        for (int i = 0; i < GameManager.ssSprites.Count; i++)
        {
            Debug.Log("Loop: " + i);

            Sprite screenShot = GameManager.ssSprites[i];
            ShowScreenshots(screenShot);

        }
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = "Amazing score: " + GameManager.finalScore.ToString();
            
        
    }

    private void ShowScreenshots(Sprite sprite)
    {
        GameObject image = Instantiate(screenShot, panel.transform);
        Image compIm = image.GetComponent<Image>();
        compIm.sprite = sprite;
    }
}
