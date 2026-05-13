using UnityEngine;

public class BladeSpinner : MonoBehaviour
{
    public float rotationSpeed = 300f;

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime, Space.World);
    }
}