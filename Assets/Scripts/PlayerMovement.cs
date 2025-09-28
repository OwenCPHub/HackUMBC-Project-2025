using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private SpriteRenderer spriteRenderer;
    public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get input for WASD and arrow keys
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right
        float moveY = Input.GetAxisRaw("Vertical");   // W/S or Up/Down
        moveInput = new Vector2(moveX, moveY).normalized;

        // Flip sprite based on horizontal movement
        if (moveX < 0)
            spriteRenderer.flipX = true;   // Facing left
        else if (moveX > 0)
            spriteRenderer.flipX = false;  // Facing right

        anim.SetFloat("horizontal", Mathf.Abs(moveX));
        anim.SetFloat("vertical", Mathf.Abs(moveY));
    }

    void FixedUpdate()
    {
        // Move the player
        rb.linearVelocity = moveInput * speed;

        
    }
}