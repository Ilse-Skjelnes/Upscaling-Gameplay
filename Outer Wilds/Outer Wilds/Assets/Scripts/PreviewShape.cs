using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

public class PreviewShape : MonoBehaviour
{

    public List<Sprite> shapeSprites = new List<Sprite>();
    public List<Color> colorSprites = new List<Color>();

    private Material mat;
    private Sprite sprite;
    private Color color;

    public Image img;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //SpriteRenderer render = GameManager.Instance.currentShape.GetComponent<SpriteRenderer>();
        //if(render.sprite != null)
        //    sprite = render.sprite;

        //mat = GameManager.Instance.currentShape.GetComponent<Material>();
        //if(render.sharedMaterial != null)
        //    color = mat.color;

        //img.sprite = shapeSprites[GameManager.Instance.shapesindex];
        //img.color = colorSprites[GameManager.Instance.shapesindex];

        img.sprite = shapeSprites[GameManager.Instance.shapesindex];
        img.color = colorSprites[GameManager.Instance.shapesindex];

    
    }
}
