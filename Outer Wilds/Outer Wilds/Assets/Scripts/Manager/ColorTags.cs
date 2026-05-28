using UnityEngine;

public class ColorTags : MonoBehaviour
{
    public enum Colors
    {
        GREEN,
        BLUE,
        RED,
        PINK,
        YELLOW,
        ORANGE,
        PURPLE,
        WHITE,
        BLACK
    }

    public enum Shapes
    {
        SQUARE,
        STAR,
        CIRCLE,
        RECTANGLE,
        HEART,
        TRIANGLE,
        HEXAGON,
        PARALLELOGRAM,
        DIAMOND
    }

    [SerializeField] private Colors COLOR;
    [SerializeField] private Shapes SHAPE;


}