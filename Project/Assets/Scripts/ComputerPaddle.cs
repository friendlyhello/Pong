using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    // Reference to ball
    public Rigidbody2D ball;

    // FixedUpdate is used for Physics
    void FixedUpdate()
    {
        // If the ball is heading towards the Computer Paddle...
        if(transform.position.x > 0.0f)
        {
            if (ball.position.y > transform.position.y)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }

            else if(ball.position.y < transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }
        }

        // If the ball is heading away from the Computer Paddle, try to re-center in the middle
        else
        {
            if (transform.position.y > 0.0f)
            {
                _rigidbody.AddForce(Vector2.down * speed);
            }

            else if (transform.position.y < 0.0f)
            {
                _rigidbody.AddForce(Vector2.up * speed);
            }
        }
    }
}
