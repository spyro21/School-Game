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
    [SerializeField] Transform t; // this.Transform component
    [SerializeField] SpriteRenderer spriteR;
    [SerializeField] Sprite timerImage;
    [SerializeField] Sprite hwImage;


    public int pointValue = 1; // number of points per collect
   

    private void OnTriggerEnter2D(Collider2D other) // called when a GameObject enters boxcollider
    {
        if (other.gameObject.CompareTag("Player")) // runs if collider has a tag of "Player"
        { 
            // calls script to change the score by 'pointvalue'
            ScoreManager.instance.ChangeScore(pointValue);

            if (Random.Range(0f, 1f) >= .5)
            {
                this.GetComponent<SpriteRenderer>().sprite = timerImage;
            }
            else {
                this.GetComponent<SpriteRenderer>().sprite = hwImage;
            }

            

            // moves the book gameobject to a random location in the 2d space
            transform.position = new Vector3(Random.Range(-6.0f,6.0f),Random.Range(-4.0f,4.0f));
        }


    }
}
