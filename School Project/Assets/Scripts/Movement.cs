using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public AudioClip walkNoise;
    public AudioSource NoiseSource;

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    private void Start()
    {
        NoiseSource.clip = walkNoise;
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            NoiseSource.Play();
        }
        
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
