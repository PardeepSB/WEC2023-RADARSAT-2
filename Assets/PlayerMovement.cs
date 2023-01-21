using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //initialization
    private float horizontal;
    private float vertical;
    public float speed = 5;
    public float jumpSpeed = 20;
    private bool isFacingRight = true;
    private Rigidbody2D sb;


    // Start is called before the first frame update
    void Start()
    {
        //initialize seaLion rigid body
        sb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        //movement logic

        //move up
        if (Input.GetKey(KeyCode.W))
        {
            sb.velocity = Vector2.up * jumpSpeed / 3;
        }

        //move down
        if (Input.GetKey(KeyCode.S))
        {
            sb.velocity = Vector2.down * jumpSpeed / 3;
        }

        //move right with up and down at the same time
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

        //move left with up and down at the same time
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

        //flip direction is required by input key
        Flip();
    }

    //flipping direction sea lion is facing based on key input
    private void Flip()
    {
        //if facing right and go left, if facing left go right
        if (isFacingRight && horizontal < 0 || !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight; //if facing right, switch to left, if facing left, switch to right
            Vector3 flipscale = transform.localScale; //transform scaling
            flipscale.x *= -1;                        //flip scale
            transform.localScale = flipscale;
        }

    }
}