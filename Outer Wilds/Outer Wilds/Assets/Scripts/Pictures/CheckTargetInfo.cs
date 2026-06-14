using UnityEngine;
using System.Collections.Generic;

public class CheckTargetInfo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.screenShotHits.Count > 0)
        {
            CheckHits();
        }
    }

    void CheckHits()
    {
        for (int i = GameManager.Instance.screenShotHits.Count - 1; i >= 0; i--)
        {
            GameObject hit = GameManager.Instance.screenShotHits[i];
            var script = hit.GetComponent<ColorTags>();
            ColorTags.Colors hitColor = script.COLOR;
            ColorTags.Shapes hitShape = script.SHAPE;
            //Collider col = hit.GetComponent<Collider>();
            //col.enabled = true;

            if (GameManager.Instance.targetColor == hitColor && GameManager.Instance.targetShape == hitShape)
            {
                Debug.Log("Correct Target");
                GameManager.Instance.isTarget = false;
                GameManager.Instance.score += 5;
                GameManager.Instance.screenShots.Add(GameManager.Instance.temporarySprite);
            }
            else if (GameManager.Instance.targetColor != hitColor || GameManager.Instance.targetShape != hitShape)
            {
                Debug.Log("False Target");
                //GameManager.Instance.score--;
            }
        }
    }
}
