using UnityEngine;

public class RotateObjects : MonoBehaviour
{
    public Vector2 turn;
    public float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        turn.x += Input.GetAxis("Mouse X");
        turn.y += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(turn.y * rotationSpeed *Time.deltaTime,  0, -turn.x * rotationSpeed * Time.deltaTime);
    }
}
