using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{

    public GameObject face;
    public Shoot shooter;
    public SpeechBubbles speech;
    Drinks desiredSpray;
    //public GameObject[] speechBubble;
    GameObject currentSpeech;

    public GameObject yuck;
    public GameObject yum;
    SpriteRenderer sr;
    public GameObject thanks;
    
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
        Debug.Log("collision");

        if (desiredSpray == shooter.SodaType)
        {
            Debug.Log("yay!");
            yum.SetActive(true);
            yuck.SetActive(false);
            face.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Instantiate(thanks, speech.currentSpeech.transform.position, speech.currentSpeech.transform.rotation);
            speech.currentSpeech.SetActive(false);
            
        }
        else
        {
            Debug.Log("boo!");
            yuck.SetActive(true);
            yum.SetActive(false);
            face.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

    }


}
