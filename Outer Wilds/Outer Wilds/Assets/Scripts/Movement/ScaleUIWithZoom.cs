
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScaleUIWithZoom : MonoBehaviour
{

    private float zoomX;
    private float zoomMultiplier = 4f;
    [SerializeField] private float minZoomX = 2f;
    [SerializeField] private float maxZoomX = 8f;

    //private float zoomY;
    //[SerializeField] private float minZoomY = 2f;
    //[SerializeField] private float maxZoomY = 8f;

    [SerializeField] private float velocity = 0f;
    [SerializeField] private float smoothTime = 0.25f;

    public GameObject cameraView;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //zoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoomX -= scroll * zoomMultiplier;
        zoomX = Mathf.Clamp(zoomX, minZoomX, maxZoomX);

        zoomX = Mathf.SmoothDamp(transform.localScale.x, zoomX, ref velocity, smoothTime);

        //zoomY += scroll * zoomMultiplier;
        //zoomY = Mathf.Clamp(zoomY, minZoomY, maxZoomY);

        //zoomY = Mathf.SmoothDamp(transform.localScale.x, zoomY, ref velocity, smoothTime);

        GameManager.Instance.rayCastSize = new Vector3(zoomX, (float)(zoomX * 0.6), 1);
        cameraView.transform.localScale = new Vector3(zoomX, (float)(zoomX * 0.6), 1);
    }
}



