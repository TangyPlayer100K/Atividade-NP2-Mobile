using UnityEngine;

public class MapGyro : MonoBehaviour
{
    private void Start()
    {
        Input.gyro.enabled = true; 
    }

    private void Update()
    {
        Quaternion rotation = Input.gyro.attitude;

        transform.localRotation = rotation;
    }
}
