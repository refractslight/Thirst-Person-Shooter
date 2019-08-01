using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMovement : MonoBehaviour
{


    public GameObject face;
    public float xPos;
    public SpawnFaces spawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MoveFace();
    }

    public void MoveFace()
    {

        xPos = face.transform.position.x;
        if (face.transform.position.x == spawn.spawnLeft.transform.position.x)
        {
            xPos -=(Random.Range(.02f, .5f));
            face.transform.Translate(Time.deltaTime * xPos, 0, 0);
            if(face.transform.position.x > 11.0f){
                Destroy(gameObject);
            }
            //Debug.Log("movement");
        }

        else{
            xPos += (Random.Range(.02f, 1));
            face.transform.Translate(xPos, 0, 0);
            if(face.transform.position.x < -11.0f){
                Destroy(gameObject);
            }
        }
    }

}
