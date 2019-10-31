using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Table of Contents:
 * 1.ScoreManager Class
 *      a. Start()
 *      b. ChangeScore(int coinValue)
 */

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // this.GameObject
    public TextMeshProUGUI text; // this.TextMeshProUGUI
    int score; // used in ChangeScore (b)

    void Start() // starting frame
    {
        if (instance == null) { // checks if this instance is null. If it is, set it to this.GameObject
            instance = this;
        }
    }

    public void ChangeScore(int coinValue) // changes int score by 'coinValue' 
    {  
        // add and display new score
        score += coinValue;
        text.text = "Knowledge: " + score.ToString();
    }
}
