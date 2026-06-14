using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public List<GameObject> shapesNColors = new List<GameObject>();
    public List<Collider> shapesColliders = new List<Collider>();
    public int shapesindex;
    public GameObject currentShape;
    
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

    public Vector3 rayCastSize;

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
        TargetPicked();
        finalScore = 0;
        screenShotHits.Clear();
        screenShots.Clear();
        ssSprites.Clear();
        SpawnShapesIn();
    }

    private void Update()
    {
        TargetPicked();
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

            GameObject spawned = GameObject.Instantiate(shapesNColors[i], spawnPoint, Quaternion.Euler(0f,0f, randomRotation));
            shapesColliders.Add(spawned.GetComponent<Collider>());
        }
    }

    public void TargetPicked()
    {
        currentShape = shapesNColors[shapesindex];
    }


}
