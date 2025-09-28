using UnityEngine;

// This script will destroy the GameObject it is attached to when a specific object stays inside its trigger for a set amount of time.
public class DestroyOnTrigger : MonoBehaviour
{
    [Header("Trigger Settings")]
    [Tooltip("The specific GameObject that will trigger the destruction (e.g., the Player).")]
    public GameObject destroyObject;

    [Tooltip("The time in seconds the object must stay in the trigger to cause destruction.")]
    public float timeToDestroy = 10.0f;

    // --- Private Variables ---
    private float timer = 0f;
    private bool isObjectInTrigger = false;

    // This function is called every frame.
    void Update()
    {
        // If the triggering object is inside the trigger, start the countdown.
        if (isObjectInTrigger)
        {
            // Increment the timer by the time elapsed since the last frame.
            timer += Time.deltaTime;

            // Check if the timer has reached the required duration.
            if (timer >= timeToDestroy)
            {
                destroyObject.SetActive(false);
            }
        }
    }

    // This function is called when another object enters a trigger collider attached to this object.
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hehe bathtub");
        // Check if the object that entered is the correct one.
       
        Debug.Log($"'{other.name}' has entered the trigger. Starting timer.");
        isObjectInTrigger = true;
        
    }

    // This function is called when another object exits a trigger collider.
    void OnTriggerExit2D(Collider2D other)
    {
        // Check if the object that exited is the correct one.
        
        Debug.Log($"'{other.name}' has left the trigger. Resetting timer.");
        isObjectInTrigger = false;
        timer = 0f; // Reset the timer back to zero.
        
    }
}