using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Table of Contents:
 * 1.EnemyFollow Class
 *      a. Start()
 *      b. OnCollisionEnter2D(Collider2D collision)
 *      c. Update()
 */


public class EnemyFollow : MonoBehaviour
{

    
    [SerializeField] GameObject healthbar; //GameObject.HealthBar
    HealthBar healthBarScript;
    [SerializeField] Collision2D collider; //this.BoxCollider2D

    public float speed; // used in Update (c)
    private Transform target; // used in Start (a) and Update (c)

    
    void Start() // starting frame
    {
        healthBarScript = healthbar.GetComponent<HealthBar>();
        // initializes the variable target to a  GameObject with the tag "Player"
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }


    public void OnCollisionEnter2D(Collision2D collision) // called when a GameObject enters boxcollider
    {
        healthBarScript.changeHealth(healthBarScript.health + .1f);
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        healthBarScript.changeUpdateRate(0f);
    }

    

    void Update() // once per frame
    {
        // moves enemy towards the target objects position with a set speed
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
