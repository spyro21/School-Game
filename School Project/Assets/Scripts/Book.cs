using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    public int pointValue = 1;
    [SerializeField] Transform t;


    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            ScoreManager.instance.ChangeScore(pointValue);

            transform.position = new Vector3(Random.Range(-6.0f,6.0f),Random.Range(-4.0f,4.0f));
        }


    }
}
