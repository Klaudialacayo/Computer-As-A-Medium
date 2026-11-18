using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private float speedX = 0f;
    private float speedY = 0f;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    public Sprite santatop;
    public Sprite santadown;
    public Sprite santaleft;
    public Sprite santaright;
    public SpriteRenderer swordRenderer;
    public Transform sword;
    void Update()
    {
        Movement();
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(speedX, speedY);

        rb.MovePosition(
            rb.position + movement * Time.fixedDeltaTime
        );
    }

    void Movement()
    {
        if (Keyboard.current.aKey.isPressed)
        {
                speedX = -moveSpeed;
                spriteRenderer.sprite = santaleft;
                sword.localScale = new Vector3(.5f, -2, 1);
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = santaright;
            sword.localScale = new Vector3(.5f, 2, 1);
        }
        else
        {
            speedX = 0;
        }

        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = santatop;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = santadown;
        }
        else
        {
            speedY = 0;
        }
    }
}
