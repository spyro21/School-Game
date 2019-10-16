using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    [SerializeField] HealthBar hb;

    // Start is called before the first frame update
    void Start()
    {
        hb.setSize(.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
