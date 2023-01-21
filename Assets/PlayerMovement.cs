using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float speed = 5;
    private bool isFacingRight = true;
    private bool isFacingDown = true;
    private Rigidbody2D sb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Flip();
    }

    private void FixedUpdate()
    {
        sb.velocity = new Vector2(horizontal * speed, sb.velocity.y);
    }

    private void Flip()
    {
        if(isFacingRight && horizontal < 0f|| !isFacingRight && horizontal > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }

    }
}
   