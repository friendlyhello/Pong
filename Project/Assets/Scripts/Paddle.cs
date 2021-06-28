using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//** PADDLE BASE CLASS */

public class Paddle : MonoBehaviour
{
    // Reference to Rigidbody2D
    protected Rigidbody2D _rigidbody2D;

    // Establish reference to Rigidbody2D
    private void Awake()
    {
        // Look for the Rigidbody2D component this script is attached to 
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
}


