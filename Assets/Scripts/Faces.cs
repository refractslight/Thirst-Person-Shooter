using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faces : MonoBehaviour
{

    public GameObject face;
    Shoot shooter;
    Drinks desiredSpray;
    public GameObject[] speechBubble;

    // Start is called before the first frame update
    void Start()
    {
        //Create desired drink
        desiredSpray = (Drinks)Random.Range(0, 6);
        Debug.Log("I want " + desiredSpray);
        //Pass drink into Speech function to actually instantiate it
        Speech(desiredSpray);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collider)
    {


        if (shooter.SodaType == desiredSpray)
        {
            Debug.Log("yay!");
        }
        else
        {
            Debug.Log("boo!");
        }

    }

    void Speech(Drinks desiredSpray)
    {
        GameObject currentSpeech;

        for (int i = 0; i < shooter.sprays.Length; i++)
        {
            if (i == (int)desiredSpray)
            {

                currentSpeech = GameObject.Instantiate(speechBubble[i], transform.position, transform.rotation);

            }
        }


    }
}
