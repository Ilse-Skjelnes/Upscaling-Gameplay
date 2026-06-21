using UnityEngine;

public class StayOnShelf : MonoBehaviour
{
    public float maxX;
    public float maxY;
    public float minY;


    // Update is called once per frame
    void Update()
    {
        StayInScreen();
    }

    private void StayInScreen()
    {
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -maxX)
        {
            transform.position = new Vector3(-maxX, transform.position.y, transform.position.z);
        }
        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
        if (transform.position.y < -minY)
        {
            transform.position = new Vector3(transform.position.x, -minY, transform.position.z);
        }

    }
}
