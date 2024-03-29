﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnFaces : MonoBehaviour
{

// Where to spawn on the left side of the screen
    public GameObject spawnLeft;
    //same, but right
    public GameObject spawnRight;
    //array of face prefabs
    public GameObject[] people;
    // the face we're actually dealing with
    public GameObject person;
    //how long until the next face spawns
    public float timeBetweenSpawn;
    //whether face is spawned on left (0), or right (1)
    public int pos;
    //How much time before scenes change (REVISE THIS)
    public float counter = 5.5f;
    //How many faces to spwan
    public int faces;
    //the facemovement script
    public FaceMovement movementScript;
    

    // Start is called before the first frame update
    void Start()
    {
        
        faces = Random.Range(6, 13);
        timeBetweenSpawn = Random.Range(1.5f, 5.5f);
        

    }

    // Update is called once per frame
    void Update()
    {
        //Countdown timer til next face
        counter -= Time.deltaTime;

        if (counter < 0)
        {
            CreateFace();
            counter = Random.Range(1, timeBetweenSpawn);
            faces -= 1;
            Debug.Log(faces);

        }
        // if (faces < 0)
        // {
        //     //pointsScript.FinalPoints(pointsScript.score);
        //     SceneManager.LoadScene(2, LoadSceneMode.Single);
        //     //return;
        // }



    }

    public void CreateFace()
    {
        //Create faces in the "wings"

        for (int i = 0; i < 1; i++)
        {
            pos = Random.Range(0, 2);
            if (pos == 0)
            {

                Debug.Log("Left");
                person = GameObject.Instantiate(people[Random.Range(0, people.Length)], new Vector3(spawnLeft.transform.position.x, spawnLeft.transform.position.y, spawnLeft.transform.position.z), transform.rotation);
                movementScript = person.GetComponent<FaceMovement>();
                StartCoroutine(movementScript.moveRight(person));
                
            }
            else
            {

                Debug.Log("Right");
                person = GameObject.Instantiate(people[Random.Range(0, people.Length)], new Vector3(spawnRight.transform.position.x, spawnRight.transform.position.y, spawnRight.transform.position.z), transform.rotation);
                movementScript = person.GetComponent<FaceMovement>();
                StartCoroutine(movementScript.moveLeft(person));
            }


        }
    }



}
