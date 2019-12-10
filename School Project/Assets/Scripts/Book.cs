using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Table of Contents:
 * 1.Book Class
 *      a. OnTriggerEnter2D(Collider2D other)
 */


public class Book : MonoBehaviour
{
    [SerializeField] GameObject health;
    HealthBar healthBarScript;

    [SerializeField] Transform t; // this.Transform component
    [SerializeField] SpriteRenderer spriteR;
    [SerializeField] Sprite timerImage;
    [SerializeField] Sprite hwImage;
    [SerializeField] float healthBonusNum = .1f;
    [SerializeField] bool isBook = true;


    
    public int pointValue = 1; // number of points per collect

    public void Start()
    {
        healthBarScript = health.GetComponent<HealthBar>();
    }


    private void OnTriggerEnter2D(Collider2D other) // called when a GameObject enters boxcollider
    {
        if (other.gameObject.CompareTag("Player")) // runs if collider has a tag of "Player"
        {
            if (isBook == true)
            {
                // calls script to change the score by 'pointvalue'
                ScoreManager.instance.ChangeScore(pointValue);
            }
            else
            {
                changeHealth(); 
            }


            if (isBook)
            {
                this.GetComponent<SpriteRenderer>().sprite = hwImage;
            }
            else {
                this.GetComponent<SpriteRenderer>().sprite = timerImage;
            }

           
           
            // moves the book gameobject to a random location in the 2d space
            transform.position = new Vector3(Random.Range(-6.0f,6.0f),Random.Range(-4.0f,4.0f));
        }


    }

    public void changeHealth() {
        if (healthBarScript.health > .3f)
        {
            healthBarScript.changeHealth(healthBarScript.health - healthBonusNum);
        }
        else
        {
            healthBarScript.changeHealth(0f);
        }
        
    }
}
