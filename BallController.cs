using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        // Launch the ball at the beginning
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }
}