using UnityEngine;

public class StayInScreen : MonoBehaviour
{
    private int maxY = 50;
    private int maxX = 50;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -maxX)
            transform.position = new Vector3(-maxX, transform.position.y, transform.position.z);
        if (transform.position.x >= maxX)
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        if (transform.position.y <= -maxY)
            transform.position = new Vector3(transform.position.x, -maxY, transform.position.z);
        if (transform.position.y >= maxY)
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);


    }
}
