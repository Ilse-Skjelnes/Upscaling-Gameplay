using UnityEngine;
using System.Collections.Generic;

public class ActivateButtons : MonoBehaviour
{
    public List<GameObject> arrows = new List<GameObject>();

    public float timer;
    public float newArrowTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= newArrowTime)
        {
            timer = 0;
            int arrowsIndex = Random.Range(0, arrows.Count - 1);
            arrows[arrowsIndex].SetActive(true);
        }
    }
}
