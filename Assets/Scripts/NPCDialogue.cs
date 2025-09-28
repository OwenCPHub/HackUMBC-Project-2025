using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public GameObject dialogueBox; // Assign your UI panel here in Inspector

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("WEEEEEEEEEEEE");
            dialogueBox.SetActive(true); // Show dialogue box
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("AHHHHHHHHHHHHHHHHHHHHHHHHH");
            dialogueBox.SetActive(false); // Hide dialogue box
    }

}