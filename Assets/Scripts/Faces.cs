﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{
    // the shooter script
    public Shoot shooter;
    //the speechbubbles script
    public SpeechBubbles speechScript;
    //the desired spray enum
    Drinks desiredSpray;
    //the lose face sprite
    public GameObject yuck;
    //the win face sprite
    public GameObject yum;
    public Points points;
    //bool to test faces/doesn't let player shoot the face again
    public bool isShot = false;
    //sprite for win
    public GameObject thanksBubble;
    private GameObject speechBubbleObject;
    // Start is called before the first frame update
    void Start()
    {
        //get Points manager to assign points upon correct shot
        points = GameObject.Find("PointsManager").GetComponent<Points>();

        //Assign SpeechBubbleManager that already exists in scene to this face. Finally.
        speechScript = GameObject.Find("SpeechBubbleManager").GetComponent<SpeechBubbles>();
        shooter = speechScript.shooter;

        //Create desired drink
        desiredSpray = (Drinks)Random.Range(0, 6);
        Debug.Log("I want " + desiredSpray);

        //Pass drink into Speech function to actually instantiate it
        speechBubbleObject = speechScript.Speech(desiredSpray, this.gameObject);
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
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                //Create Thanks bubble and sets parent to face
                thanksBubble = GameObject.Instantiate(thanksBubble, speechBubbleObject.transform.position, speechBubbleObject.transform.rotation);
                thanksBubble.transform.parent = this.transform;
                //disactivate original speech bubble with order
                speechBubbleObject.SetActive(false);
                // add a point to the score
                points.AddPoint();
                //cannot be shot again
                isShot = true;
            }
            else
            {
                //Changes face to "yuck"
                Debug.Log("boo!");
                //enable lose face, disable win face
                yuck.SetActive(true);
                yum.SetActive(false);
                //disables the parent sprite
                this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                //removes order speech bubble
                speechBubbleObject.SetActive(false);
            }
        }


    }


}
