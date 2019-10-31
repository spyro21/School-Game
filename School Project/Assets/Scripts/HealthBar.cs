using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
    
    [SerializeField] public int WaitingTime = 5; // time before healthbar increases
    [SerializeField] float healthUpdateRate = .01f; // rate at which health will update;
    [SerializeField] SceneLoader sceneload; // SceneLoader GameObject

    private Transform bar;
    public float health = 0f;
    public bool isStress = false;
    public int isRunning = 1;


    // Start is called before the first frame update
    void Start()
    {
        //
        bar = transform.Find("Bar");
        setSize(health);
    }

    void Update()
    {
        if (isRunning == 1 && health <= 1) {
            StartCoroutine(wait());
        }
        setSize(health);

        // saved for later implementation
        if (health >= 0) {
            isStress = true;
        }

        // checks if healthbar should load the game over scene
        if (health >= 1) {
            loadGameOver();
        }

        
    }

    
    public IEnumerator wait() // waits WaitingTime seconds until it runs {code}
    { 
        isRunning = 0;
        yield return new WaitForSeconds(WaitingTime);
        health += healthUpdateRate; // {code}

        Debug.Log(health);
        isRunning = 1;
    }


    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized,1f);
    }

    public void loadGameOver() {
        sceneload.LoadNextScene();
    }
    
}
