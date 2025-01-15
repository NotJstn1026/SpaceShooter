using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float horizontalInput;
    private float verticalInput;
    private Vector2 movementDirection;

    private Vector2 velocity;

    private float movespeed = 200f;
    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void FixedUpdate()
    {
         rb2D.velocity = velocity * Time.deltaTime;
    }

    private void Movement()
    {
        velocity = Vector2.zero;

        verticalInput = Input.GetAxisRaw("Vertical");
        horizontalInput = Input.GetAxisRaw("Horizontal");
        movementDirection = new Vector2(horizontalInput, verticalInput).normalized;

        velocity = new Vector2(movementDirection.x * movespeed, movementDirection.y * movespeed);
    }
}
