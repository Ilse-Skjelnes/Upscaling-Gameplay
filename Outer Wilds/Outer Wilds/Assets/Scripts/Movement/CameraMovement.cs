using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovement : MonoBehaviour
{
    private Vector3 position;

    [SerializeField] private float movementSpeed = 0.1f;



    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        Movement();
        transform.position = position;

        
    }

    private void Movement()
    {
        position = new Vector2(transform.position.x, transform.position.y);

        if (Input.GetKey(KeyCode.W))
        {
            position += new Vector3(0, movementSpeed);
        }
        else if (Input.GetKey(KeyCode.S)) 
        {
            position += new Vector3(0, -movementSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            position += new Vector3(-movementSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position += new Vector3(movementSpeed, 0);
        }
    }
}
