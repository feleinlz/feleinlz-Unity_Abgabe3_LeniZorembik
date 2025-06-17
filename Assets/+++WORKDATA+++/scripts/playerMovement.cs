using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public float speed;
    public float input;


    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        playerRB.linearVelocity = new Vector2(input * speed, playerRB.linearVelocity.y);
    }
}
