using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    [SerializeField] private float rotationZ;
    [SerializeField] private float rotationPowerPositive;
    [SerializeField] private float rotationPowerNegative;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float rotationMin;
    [SerializeField] private float rotationMax;

    [SerializeField] private float t;

    [SerializeField] private bool positiveRotation;

    private void Start()
    {
        rotationZ = Mathf.Lerp(rotationMin, rotationMax, 3);
        rotationSpeed = rotationPowerPositive;
    }
    private void Update()
    {
        
        RotateScreen();
    }
    private void RotateScreen()
    {
        t += rotationSpeed * Time.deltaTime;
        
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);

        if (transform.rotation.z == 3)
        {
            positiveRotation = true;
            t = 0;
            //rotationMax = -3;
            //rotationMin = 3;

            //rotationSpeed = rotationPowerNegative;
            //t = 0;
        }

        if (transform.rotation.z == -3)
        {
            positiveRotation = false;

            t = 0;
            //rotationMax = -3;
            //rotationMin = 3;

            //rotationSpeed = rotationPowerNegative;
            //t = 0;
        }
        
        if (positiveRotation)
        {
            rotationZ = Mathf.Lerp(rotationMax, rotationMin, t);
        }
        if (!positiveRotation)
        {
            rotationZ = Mathf.Lerp(rotationMin, rotationMax, t);
        }
    }
}
