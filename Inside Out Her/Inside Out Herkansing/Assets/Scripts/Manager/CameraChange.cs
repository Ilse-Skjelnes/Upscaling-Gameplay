using UnityEngine;

public class CameraChange : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BookDrawing()
    {
        Camera.main.orthographic = true;
    }

    public void BookShelf()
    {
        Camera.main.orthographic = false;
    }
}
