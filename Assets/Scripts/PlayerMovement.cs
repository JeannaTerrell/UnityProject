using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;
    public Transform ceilingCheck;
    public Transform groundCheck;
    public LayerMask groundObjects;
    public float checkRadius;
    public int maxJumpCount;

    private Rigidbody2D rb;
    private bool facingRight = true;
    private float moveDirection;
    private bool isJumping = false;
    private bool isGrounded;
    private int jumpCount;

    //Called by the game engine at the start of the game
    private void Awake()
    {
        //RigidBody2D is the class provided by the Unity engine to handle physics on game objects
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        jumpCount = 0;
        HealthSystem healthSystem = new HealthSystem(100);
        Debug.Log("Health: " +healthSystem.GetHealth());
    }

    // Called by the game engine once per frame
    void Update()
    {
        ProcessInputs();

        Animate();

    }

    //Called up to 60 times per second by the game engine
    private void FixedUpdate()
    {
        //Game engine funtion to check for objects within a circle at a specified point
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundObjects);
        if(isGrounded)
        {
            jumpCount = 0;
        }

        Move();
    }

    private void Move()
    {
        var x = new Vector2(0, 0);

        //Applies a consistent velocity to a game object
        rb.velocity = new Vector2(moveDirection * moveSpeed, rb.velocity.y);
        if(isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jumpCount++;
        }
        isJumping = false;
    }

    private void Animate()
    {
        if (moveDirection > 0 && !facingRight)
        {
            FlipCharacter();
        }
        else if (moveDirection < 0 && facingRight)
        {
            FlipCharacter();
        }
    }

    private void ProcessInputs()
    {
        moveDirection = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && jumpCount < maxJumpCount)
        {
            isJumping = true;
        }
    }

    private void FlipCharacter()
    {
        facingRight = !facingRight;

        //Rotates the game object on the y-axis
        transform.Rotate(0f, 180f, 0f);
    }

   

}
