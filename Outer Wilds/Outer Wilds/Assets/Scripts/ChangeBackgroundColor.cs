using UnityEngine;

public class ChangeBackgroundColor : MonoBehaviour
{
    [SerializeField] private Camera cameraRef;
    public Color[] colors;
    public float colorChangeSpeed;
    public float time;
    private float currentTime;
    private int colorIndex;

    private void Awake()
    {
        cameraRef = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        ColorChange();
        ColorChangeTime();
    }

    private void ColorChange()
    {
        cameraRef.backgroundColor = Color.Lerp(cameraRef.backgroundColor, colors[colorIndex], colorChangeSpeed * Time.deltaTime);
    }

    private void ColorChangeTime()
    {
        if (currentTime <= 0)
        {
            colorIndex++;
            CheckColorIndex();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndex()
    {
        if (colorIndex >= colors.Length)
        {
            colorIndex = 0;
        }
    }
    private void OnDestroy()
    {
        cameraRef.backgroundColor = colors[0];
    }
}
