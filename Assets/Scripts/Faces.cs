using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{

    // The face we're instantiating
    public GameObject face;
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

    // Start is called before the first frame update
    void Start()
    {
        //get Points manager to assign points upon correct shot
        points = GameObject.Find("PointsManager").GetComponent<Points>();
        //Assign SpeechBubbleManager that already exists in scene to this face. Finally.
        speechScript = GameObject.Find("SpeechBubbleManager").GetComponent<SpeechBubbles>();
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
                //Create Thanks bubble and sets parent to face
                thanksBubble = GameObject.Instantiate(thanksBubble, speechScript.currentSpeech.transform.position, speechScript.currentSpeech.transform.rotation);
                thanksBubble.transform.parent = face.transform;
                //disactivate original speech bubble with order
                speechScript.currentSpeech.SetActive(false);
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
                face.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                //removes order speech bubble
                speechScript.currentSpeech.SetActive(false);
            }
        }


    }


}
