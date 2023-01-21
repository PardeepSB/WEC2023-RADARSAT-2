using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    public float speed = 5;
    public float jumpSpeed = 20;

    private bool isFacingRight = true;
    private bool isFacingDown = false;
    private Rigidbody2D sb;



    // Start is called before the first frame update
    void Start()
    {
        sb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKey(KeyCode.W))
        {
            sb.velocity = Vector2.up * jumpSpeed / 3;
        }
        if (Input.GetKey(KeyCode.S))
        {
            sb.velocity = Vector2.down * jumpSpeed / 3;
        }

        if (Input.GetKey(KeyCode.D))
        {
            sb.velocity = Vector2.right * speed;
            if (Input.GetKey(KeyCode.W))
            {
                sb.velocity = Vector2.up * jumpSpeed / 3;
            }
            if (Input.GetKey(KeyCode.S))
            {
                sb.velocity = Vector2.down * jumpSpeed / 3;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            sb.velocity = Vector2.left * speed;
            if (Input.GetKey(KeyCode.W))
            {
                sb.velocity = Vector2.up * jumpSpeed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                sb.velocity = Vector2.down * jumpSpeed / 3;
            }
        }
        Flip();
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }

    }
}