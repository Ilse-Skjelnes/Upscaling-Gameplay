using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Rendering.UnifiedRayTracing;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public List<GameObject> shapesNColors = new List<GameObject>();
    
    public List<GameObject> screenShotHits = new List<GameObject>();
    public bool isTarget;

    public string theTargetColor;
    public ColorTags.Colors targetColor;
    public ColorTags.Shapes targetShape;

    [SerializeField] private float minYSpawn;
    [SerializeField] private float maxYSpawn;
    [SerializeField] private float minXSpawn;
    [SerializeField] private float maxXSpawn;

    public Sprite temporarySprite;

    public List<Sprite> screenShots = new List<Sprite>();
    public static List<Sprite> ssSprites = new List<Sprite>();


    [SerializeField] private TextMeshProUGUI targetShapeText;
    [SerializeField] private TextMeshProUGUI targetColorText;

    [SerializeField] private TextMeshProUGUI scoreText;
    public int score;
    public static int finalScore;

    private void Awake()
    {
        if (instance != null)
            Destroy(instance);
        instance = this;

        
    }

    private void Start()
    {
        finalScore = 0;
        screenShotHits.Clear();
        screenShots.Clear();
        ssSprites.Clear();
        SpawnShapesIn();
    }

    private void Update()
    {
        targetColorText.text = targetColor.ToString();
        targetShapeText.text = targetShape.ToString() ;
        scoreText.text = score.ToString();
        ssSprites = screenShots;
        finalScore = score;
    }

    private void SpawnShapesIn()
    {
        for (int i = shapesNColors.Count - 1; i >= 0; i--)
        {
            float xSpawn = Random.Range(minXSpawn, maxXSpawn);
            float ySpawn = Random.Range(minYSpawn, maxYSpawn);

            Vector3 spawnPoint = new Vector3(xSpawn, ySpawn, 0);

            float randomRotation = Random.Range(0, 360);

            GameObject.Instantiate(shapesNColors[i], spawnPoint, Quaternion.Euler(randomRotation,0f, 0f));
        }
    }
}
