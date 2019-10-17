using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{

    [SerializeField] private HealthBar healthBar;
    // Start is called before the first frame update
    private void Start()
    {
        healthBar.setSize(.2f);
    }
}
