using UnityEngine;
using System.Collections.Generic;

public class PictureTarget : MonoBehaviour
{
    //public GameObject target;
    public int randomIndex;
    public List<ColorTags> tags = new List<ColorTags>();

    ColorTags.Colors Color;
    private void Start()
    {
        PickTarget();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.Instance.isTarget)
        {
            PickTarget();
        }
    }

    void PickTarget()
    {
        randomIndex = Random.Range(0, tags.Count);
        var target = tags[randomIndex];

        Color = target.COLOR;
        string theColor = target.COLOR.ToString();

        GameManager.Instance.targetColor = Color;
        GameManager.Instance.targetShape = target.SHAPE;

        GameManager.Instance.isTarget = true;
    }
}
