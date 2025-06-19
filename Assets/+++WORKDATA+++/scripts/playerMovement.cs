using System;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float speed;
    public float input;
    public SpriteRenderer playerSprite;
    public float jumpForce;
    public LayerMask groundLayer;
    private bool grounded;
    public Transform feetPosition;
    public float groundCheckRadius;

    public float jumpTime = 0.35f;
    public float jumpTimeCounter;
    private bool isJumping;
    
    public CoinManager coinManager;
    public DiamondManager diamondManager;

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
        if (input < 0)
        {
            playerSprite.flipX = true;
        }
        else if (input > 0)
        {
            playerSprite.flipX = false;
        }
        
        grounded = Physics2D.OverlapCircle(feetPosition.position, groundCheckRadius, groundLayer);

        if (grounded && Input.GetButtonDown("Jump"))
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            playerRB.linearVelocity = Vector2.up * jumpForce;
        }

        if (Input.GetButton("Jump") && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                playerRB.linearVelocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        
        if (Input.GetButtonUp("Jump"))
        {
            isJumping = false;
        }
    }

    void FixedUpdate()
    {
        playerRB.linearVelocity = new Vector2(input * speed, playerRB.linearVelocity.y);
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        
        Debug.Log("collided with" + other.gameObject.name);
        
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinManager.coinCount++;
        }
        
    }
   
}
