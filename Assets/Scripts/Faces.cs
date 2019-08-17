﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{

    public GameObject face;
    public Shoot shooter;
    public SpeechBubbles speechScript;
    //public GameObject speech;
    Drinks desiredSpray;
    public GameObject yuck;
    public GameObject yum;
    public Points points;
    public bool isShot = false;
    public GameObject thanksBubble;

    // Start is called before the first frame update
    void Start()
    {
        //Assign SpeechBubbleManager in scene to this face. Finally.
        speechScript = GameObject.Find("SpeechBubbleManager").GetComponent<SpeechBubbles>();
        //speech.GetComponent<SpeechBubbles>();
        shooter.GetComponent<Shoot>();
        //Create desired drink
        desiredSpray = (Drinks)Random.Range(0, 6);
        Debug.Log("I want " + desiredSpray);
        //Pass drink into Speech function to actually instantiate it
        speechScript.Speech(desiredSpray, face);
    }



    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (isShot == true)
        {
            return;
        }
        else
        {
            if (desiredSpray == shooter.SodaType)
            {
                //Reward player for correct drink
                Debug.Log("yay!");
                //change faces to reward
                yum.SetActive(true);
                yuck.SetActive(false);
                //disables the parent sprite
                face.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                //Create Thanks bubble
                thanksBubble = GameObject.Instantiate(thanksBubble, speechScript.currentSpeech.transform.position, speechScript.currentSpeech.transform.rotation);
                thanksBubble.transform.parent = face.transform;
                speechScript.currentSpeech.SetActive(false);
                points.AddPoint();
                isShot = true;
            }
            else
            {
                //Changes face to "yuck"
                Debug.Log("boo!");
                yuck.SetActive(true);
                yum.SetActive(false);
                //disables the parent sprite
                face.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            }
        }


    }


}
