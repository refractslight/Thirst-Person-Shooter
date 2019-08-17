using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMovement : MonoBehaviour
{

    public float speed = 0.5f;
    public GameObject face;
    public GameObject endLeft;
    public GameObject endRight;
    //public GameObject spawnLeft;
    public SpawnFaces faceSpawn;

    // Start is called before the first frame update

    void Start()
    {
        faceSpawn = GameObject.Find("FaceManager").GetComponent<SpawnFaces>();
    }

    // Update is called once per frame
    void Update()
    {

    }

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
