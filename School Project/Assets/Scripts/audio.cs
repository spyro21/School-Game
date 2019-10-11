using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") == 0)
        {
            MusicSource.Play();
        }
        else if (Input.GetAxisRaw("Vertical") == 0)
        {
            MusicSource.Play();
        }
    }
}
