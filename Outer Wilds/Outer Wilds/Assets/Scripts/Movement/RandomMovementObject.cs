using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomMovementObject : MonoBehaviour
{
    private Rigidbody rbTarget;

    [SerializeField] private float maxSameDirection = 1f;
    [SerializeField] private float minSameDirection = 0.1f;
    private float changeDirectionTimer = 1;

    [SerializeField] private int minDirectionChange = 0;
    [SerializeField] private int maxDirectionChange = 360;

    [SerializeField] private float movementSpeed = 1f;


    private void Awake()
    {
        rbTarget = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        RandomChangeDirection();
        MoveObject();
    }

    private void RandomChangeDirection()
    {
        float newRandomTimer;
        changeDirectionTimer -= Time.deltaTime;
        if (changeDirectionTimer <= 0)
        {
            PickNewDirection();

            newRandomTimer = Random.Range(minSameDirection, maxSameDirection);
            changeDirectionTimer = newRandomTimer;
        }
    }

    private void PickNewDirection()
    {
        int randomDirection = Random.Range(minDirectionChange, maxDirectionChange + 1);
        transform.rotation = Quaternion.Euler(0, 0, transform.rotation.z + randomDirection);
    }

    private void MoveObject()
    {
        transform.position += transform.TransformDirection(Vector3.up * Time.deltaTime * movementSpeed);
        //rbTarget.linearVelocity = Vector3.i * Time.deltaTime * movementSpeed;
    }
}
