using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 200.0f;

    // Update is called once per frame
    private void Awake ()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    public void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    // Reset the game
    public void ResetPosition()
    {
        _rigidbody.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
    }

    public void AddStartingForce()
    {
        float y = Random.value < 0.5 ? -1.0f : 1.0f;
        float x = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody.AddForce(direction * speed);
    }

    // Add Force function callable from any script
    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
}
