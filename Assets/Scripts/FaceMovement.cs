using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMovement : MonoBehaviour
{

    // speed that face moves across screen
    public float speed;

    // destroy point on left side of screen
    public GameObject endLeft;
    //destroy point on right side of screen
    public GameObject endRight;

    //Where the face spawns
    public SpawnFaces faceSpawn;

    // Start is called before the first frame update
    void Start()
    {


        //set the speed for the face to move
        speed = Random.Range(2f, 3.5f);
    }

    //Coroutines that handle movement of faces.
    public IEnumerator moveLeft(GameObject moveMe)
    {
        Debug.Log("MoveLeft coroutine started");
        Vector2 spawnRight = moveMe.transform.position;
        for (float i = 0; i < 1; i += Time.deltaTime / speed)
        {
            moveMe.transform.position = Vector2.Lerp(spawnRight, endLeft.transform.position, i);
            yield return null;
        }
        Destroy(moveMe);
    }
    public IEnumerator moveRight(GameObject moveMe)
    {
        Debug.Log("MoveRight coroutine started");
        Vector2 spawnLeft = moveMe.transform.position;
        for (float i = 0; i < 1; i += Time.deltaTime / speed)
        {
            moveMe.transform.position = Vector2.Lerp(spawnLeft, endRight.transform.position, i);
            yield return null;
        }
        Destroy(moveMe);
    }

}
