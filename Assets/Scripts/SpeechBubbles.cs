﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbles : MonoBehaviour
{

    public GameObject[] speechBubble;
    public Shoot shooter;
    public GameObject currentSpeech;
    public float startPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Speech(Drinks desiredSpray)
    {

        for (int i = 0; i < shooter.sprays.Length; i++)
        {
            if (i == (int)desiredSpray)
            {

                currentSpeech = GameObject.Instantiate(speechBubble[i], new Vector3(transform.position.x + startPos, transform.position.y, transform.position.z), transform.rotation);

            }
        }


    }
}
