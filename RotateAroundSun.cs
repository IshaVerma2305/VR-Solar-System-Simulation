using UnityEngine;

public class RotateAroundSun : MonoBehaviour
{
    public Transform sunTransform; // Drag and drop the sun's transform here in the Inspector
    public float rotationSpeed = 10f; // Speed of rotation in degrees per second

    void Update()
    {
        // Rotate around the sun's z-axis
        transform.RotateAround(sunTransform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
