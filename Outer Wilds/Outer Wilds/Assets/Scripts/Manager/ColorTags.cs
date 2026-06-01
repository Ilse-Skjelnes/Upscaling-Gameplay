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
        DIAMOND
    }

    public Colors COLOR;
    public Shapes SHAPE;


}