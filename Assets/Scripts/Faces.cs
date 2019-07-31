using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{

    public GameObject face;
    public Shoot shooter;
    public SpeechBubbles speech;
    Drinks desiredSpray;
    GameObject currentSpeech;

    public GameObject yuck;
    public GameObject yum;
    SpriteRenderer sr;
    public GameObject thanks;
    public Points points;
    
    // Start is called before the first frame update
    void Start()
    {

        speech.GetComponent<SpeechBubbles>();
        shooter.GetComponent<Shoot>();
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
            GameObject.Instantiate(thanks, speech.currentSpeech.transform.position, speech.currentSpeech.transform.rotation);
            speech.currentSpeech.SetActive(false);
            points.AddPoint();
            
            
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
