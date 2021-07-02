using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : Paddle
{
    // Variable to hold a Vector2 direction
    private Vector2 _direction;

    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            _direction = Vector2.up;
        }

        else if(Input.GetKey(KeyCode.S))
        {
            _direction = Vector2.down;
        }

        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if(_direction.sqrMagnitude != 0)
        {
            // Access Rigidbody and speed from the Paddle base class    
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
