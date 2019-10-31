using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Table of Contents:
 * 1.public class
 *      a. Start()
 *      b. Update()
 *      c. onTriggerEnter2D(Collider2D other)
 *      d. FixedUpdate()
 */


public class Movement : MonoBehaviour
{
    
    public float moveSpeed = 5f; // used in FixedUpdate function
    public Rigidbody2D rb; // Player.RigidBody2D
    Vector2 movement; // used in Update (b), FixedUpdate (d)

    private void Start() // starting frame
    {
        
    }
   
    void Update() // once per frame
    {
       // sets the movement vector to input, where input = arrow keys
        movement.x = Input.GetAxisRaw("Horizontal"); 
        movement.y = Input.GetAxisRaw("Vertical");

        
        
    }

    private void OnTriggerEnter2D(Collider2D other) // called when a GameObject enters boxcollider 
    {
        
    }

    private void FixedUpdate() // once per frame (physics)
    {
        // uses Rigidbody to move GameObject 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
