﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        /*
         *  sets the movement vector to Input 
         */
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
