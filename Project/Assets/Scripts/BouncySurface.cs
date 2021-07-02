using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    // The strength of the bounce applied to a surface/object
    public float bounceStrentgh;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Get reference from the Ball class/script
        Ball ball = collision.gameObject.GetComponent<Ball>();

        // No garauntee that the object that collided is the ball, so check...
        if(ball != null) // if it wasn't the ball, don't run!
        {
            // Normal is a vector pointing away at the surface, at that point
            Vector2 normal = collision.GetContact(0).normal;

            // Calling AddForce() from Ball class/script
            ball.AddForce(-normal * bounceStrentgh); // -normal is just opposite direction
        }
    }
}
