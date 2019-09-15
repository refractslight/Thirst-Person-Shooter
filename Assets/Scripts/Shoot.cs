using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Drinks { Soda, Orange, Lime, Pink, Lemonade, Water };
public class Shoot : MonoBehaviour
{


    // where the spray will be coming from
    public GameObject gun;

    //enum to store drink type
    public Drinks SodaType;
    //how to rotate the gameobject to look like it's really coming out of the spray gun
    public float sprayRotate = -68.319f;
    // Array of spray sprites
    public GameObject[] sprays;
    //offset between gun prefab and sprays
    public GameObject offset;
    //how long until the spray disappears
    public float deathTime;
    // offset between gun and prefab on opposite side of screen (when the gun flips)
    public GameObject offsetReverse;
    //array of audio for each spray
    public AudioClip[] spray;
    //audio source for spray noises
    public AudioSource sprayer;


    // Update is called once per frame
    void Update()
    {
        // makes gun follow mouse
        Vector3 mousePos = Input.mousePosition;
        //Input Controls
        // Sends type of drink to Spray function
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SodaType = Drinks.Soda;
            Spray(Drinks.Soda);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SodaType = Drinks.Orange;
            Spray(Drinks.Orange);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SodaType = Drinks.Lime;
            Spray(Drinks.Lime);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SodaType = Drinks.Pink;
            Spray(Drinks.Pink);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SodaType = Drinks.Lemonade;
            Spray(Drinks.Lemonade);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SodaType = Drinks.Water;
            Spray(Drinks.Water);

        }

    }

    //takes in drink type, loops through array of art assets
    void Spray(Drinks type)
    {
        GameObject currentSp;

        for (int i = 0; i < sprays.Length; i++)
        {
            // if the art asset is the same as the drink type, instantiate
            if (i == (int)type)
            {
                //creates sprays
                //flips sprays depending on where the gun is when its sprayed
                if (gun.transform.position.x < 0)
                {
                    currentSp = GameObject.Instantiate(sprays[i], new Vector3(offset.transform.position.x, offset.transform.position.y, offset.transform.position.z), transform.rotation * Quaternion.Euler(0f, 0f, sprayRotate));
                    currentSp.transform.SetParent(offset.transform);
                    sprayer.PlayOneShot(spray[Random.Range(0, spray.Length)]);
                    Debug.Log("Made " + type);
                    Destroy(currentSp, deathTime);
                }
                else
                {

                    currentSp = GameObject.Instantiate(sprays[i], new Vector3(offsetReverse.transform.position.x, offsetReverse.transform.position.y, offsetReverse.transform.position.z), transform.rotation * Quaternion.Euler(0f, 0f, -sprayRotate));
                    currentSp.transform.SetParent(offset.transform);
                    sprayer.PlayOneShot(spray[Random.Range(0, spray.Length)]);
                    Debug.Log("Made Reverse " + type);
                    Destroy(currentSp, deathTime);
                }

            }


        }

    }


}

