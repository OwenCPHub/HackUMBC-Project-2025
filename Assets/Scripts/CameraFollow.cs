using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;       // The player sprite
    public float smoothing = 5f;   // How smoothly the camera follows

    private Vector3 offset;

    void Start()
    {
        // Keep the initial Y and Z offset
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Only follow X axis
        Vector3 targetPos = new Vector3(target.position.x + offset.x, transform.position.y, transform.position.z);

        // Smoothly move camera along X
        transform.position = Vector3.Lerp(transform.position, targetPos, smoothing * Time.deltaTime);
    }
}