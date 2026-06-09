using Unity.VisualScripting;
using UnityEngine;

public class ScaleSprite : MonoBehaviour
{
    [SerializeField] private GameObject theSprite;
    [SerializeField] private bool ScaleUp;


    [SerializeField] private float minScale;
    [SerializeField] private float maxScale;
    [SerializeField] private float scaleTime;

    [SerializeField] private float transformMin;
    [SerializeField] private float transformMax;

    [SerializeField] private AudioClip femaleRunning;
    [SerializeField] private AudioClip femaleWalking;
    [SerializeField] private AudioSource femaleSource;

    public float t;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        femaleSource.Play();
    }

    // Update is called once per frame
    void Update()
    {


        t += scaleTime * Time.deltaTime;
        float scaling = Mathf.Lerp(minScale, maxScale, t);
        theSprite.transform.localScale = new Vector3(scaling, scaling, 1);

        float transformY = Mathf.Lerp(transformMin, transformMax, t);
        theSprite.transform.position = new Vector3(transform.position.x, transformY, transform.position.z);
    }

    public void CheckRunningOrNot(bool run)
    {
        if (!run)
        {
            scaleTime = 0.05f;
            femaleSource.clip = femaleWalking;
        }

        if (run)
        {
            scaleTime = 0.5f;
            femaleSource.clip = femaleRunning;
        }
    }
}
