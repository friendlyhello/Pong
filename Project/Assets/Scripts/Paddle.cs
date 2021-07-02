using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//** PADDLE BASE CLASS */

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;

    // Reference to Rigidbody2D
    protected Rigidbody2D _rigidbody;
    

    // Establish reference to Rigidbody2D
    private void Awake()
    {
        // Look for the Rigidbody2D component this script is attached to 
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}


