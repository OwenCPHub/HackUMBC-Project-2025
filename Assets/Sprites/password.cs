using UnityEngine;
using UnityEngine.UI;
using TMPro;

// This attribute ensures the script is always on an object that has an InputField component.
[RequireComponent(typeof(TMP_InputField))] 
public class PasswordValidator : MonoBehaviour
{
    // --- UI REFERENCES ---
    // This is now private as we get it automatically from this GameObject.
    private TMP_InputField passwordInputField; 
    public GameObject hideItPlease;
    
    // The button is now optional. You can leave this unassigned.
    [Header("UI Elements")]
    public Button submitButton;

    // --- PASSWORD SETTINGS ---
    [Header("Password Settings")]
    [SerializeField] private string correctPassword = "unity"; // Set your desired password here

    // --- SECRET ACTION ---
    [Header("Secret Action")]
    public GameObject objectWithCollider; // Assign the object with the collider you want to disable.

    // Awake is called when the script instance is being loaded.
    // It's the best place to get component references.
    void Awake()
    {
        // Get the InputField component attached to this same GameObject.
        passwordInputField = GetComponent<TMP_InputField>();

    
    }

    void Start()
    {
        // Add a listener to the submit button if it's assigned.
        if (submitButton != null)
        {
            submitButton.onClick.AddListener(CheckPassword);
        }

        // This listens for when the user presses "Enter" while the input field is selected.
        passwordInputField.onSubmit.AddListener((value) => CheckPassword());
    }

    // This method checks the entered password against the correct one.
    public void CheckPassword()
    {
        string enteredPassword = passwordInputField.text;

        // If the entered password matches the correct one, run the success logic.
        if (enteredPassword == correctPassword)
        {
            // --- SUCCESS ---
            Debug.Log("Password Correct! Unlocking secret...");
            
            // TODO: Add your logic for a correct password here!
            UnlockSecret();
            
        }
        else
        {
            // --- FAILURE ---
            Debug.Log("Password Incorrect! Try again.");
            // You could optionally clear the input field on failure.
            passwordInputField.text = "";
        }
    }

    // An example function to call when the password is correct.
    private void UnlockSecret()
    {
        Debug.Log("Secret has been unlocked!");

        // --- NEW: Disable the specified collider ---
        if (objectWithCollider != null)
        {
            objectWithCollider.SetActive(false);
        }
        hideItPlease.SetActive(false);
    }
}

