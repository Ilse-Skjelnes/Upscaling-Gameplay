using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Camera mainCam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DrawingBook()
    {
        Camera.main.orthographic = true;
    }
}
