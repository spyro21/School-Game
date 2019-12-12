using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    [SerializeField] GameObject health;
    [SerializeField] float healthBonusNum = .1f;
    HealthBar healthBarScript;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            changeHealth();
            transform.position = new Vector3(Random.Range(-6.0f, 6.0f), Random.Range(-4.0f, 4.0f));
        }
        

    }



    // Update is called once per frame
    public void changeHealth()
    {
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
