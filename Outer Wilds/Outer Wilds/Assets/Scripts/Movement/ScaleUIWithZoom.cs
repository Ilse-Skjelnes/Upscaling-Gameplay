using UnityEngine;

public class ScaleUIWithZoom : MonoBehaviour
{

    private float zoom;
    private float zoomMultiplier = 4f;
    [SerializeField] private float minZoom = 2f;
    [SerializeField] private float maxZoom = 8f;
    [SerializeField] private float velocity = 0f;
    [SerializeField] private float smoothTime = 0.25f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //zoom = cam.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        zoom += scroll * zoomMultiplier;
        zoom = Mathf.Clamp(zoom, minZoom, maxZoom);
        zoom = Mathf.SmoothDamp(transform.localScale.x, zoom, ref velocity, smoothTime);

        transform.localScale = new Vector3(zoom, zoom, 1);
    }
}

