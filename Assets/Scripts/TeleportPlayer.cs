using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform player;          // Player GameObject
    public Vector3 teleportPosition;  // Where to teleport
    public Camera newCamera;          // Camera to switch to
    public Camera oldCamera;          // Camera to switch from (optional)

    void OnTriggerEnter2D(Collider2D other)
    {
            // Teleport the player
            player.position = teleportPosition;

            // Switch cameras
            if (newCamera != null) newCamera.gameObject.SetActive(true);
            if (oldCamera != null) oldCamera.gameObject.SetActive(false);
       
    }
}