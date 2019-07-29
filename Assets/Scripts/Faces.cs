using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{

    public GameObject face;
    Shoot shooter;
    SpeechBubbles speech;
    Drinks desiredSpray;
    public GameObject[] speechBubble;
    GameObject currentSpeech;
    
    // Start is called before the first frame update
    void Start()
    {
        //Create desired drink
        desiredSpray = (Drinks)Random.Range(0, 6);
        Debug.Log("I want " + desiredSpray);
        //Pass drink into Speech function to actually instantiate it
        speech.Speech(desiredSpray);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("collision");

        if (desiredSpray == shooter.SodaType)
        {
            Debug.Log("yay!");
        }
        else
        {
            Debug.Log("boo!");
        }

    }

   
}
