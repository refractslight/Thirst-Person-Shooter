using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFaces : MonoBehaviour
{

    public GameObject spawnLeft;
    public GameObject spawnRight;
    public GameObject[] people;
    public GameObject person;
    public float timeBetweenSpawn = 5.5f;
    public int pos;
    public float counter = 5.5f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        //Countdown timer til next face
        counter -= Time.deltaTime;

        if (counter < 0)
        {
            CreateFace();
            Debug.Log("face Made");
            counter = Random.Range(1, timeBetweenSpawn);
        }
        

    }

    public void CreateFace()
    {
        //Create faces in the "wings"

        for (int i = 0; i < 1; i++)
        {
            pos = Random.Range(0, 2);
            if (pos == 0)
            {

                Debug.Log(pos);
                person = GameObject.Instantiate(people[Random.Range(0, people.Length)], new Vector3(spawnLeft.transform.position.x, spawnLeft.transform.position.y, spawnLeft.transform.position.z), transform.rotation);
            }
            else
            {

                Debug.Log(pos);
                person = GameObject.Instantiate(people[Random.Range(0, people.Length)], new Vector3(spawnRight.transform.position.x, spawnRight.transform.position.y, spawnRight.transform.position.z), transform.rotation);
            }


        }
    }



}
