using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HealthBar : MonoBehaviour
{
    private Transform bar;

    public float health = 0f;
    public bool isStress = false;
    public int isRunning = 1;
    [SerializeField] public int WaitingTime = 1;
    [SerializeField] float healthUpdateRate = .01f;
    [SerializeField] SceneLoader sceneload;



    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar");
        setSize(health);

    }

    void Update()
    {
        if (isRunning == 1 && health <= 1) {
            StartCoroutine(wait());
        }
        setSize(health);

        if (health >= 0) {
            isStress = true;
        }

        if (health >= 1) {
            loadGameOver();
        }

        
    }

    public IEnumerator wait() {
        isRunning = 0;
        yield return new WaitForSeconds(WaitingTime);
        health += healthUpdateRate;

        Debug.Log(health);
        isRunning = 1;
    }


    public void setSize(float sizeNormalized) {
        bar.localScale = new Vector3(sizeNormalized,1f);
    }

    public void loadGameOver() {
        sceneload.LoadNextScene();
    }
    
}
