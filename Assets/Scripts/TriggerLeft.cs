using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeft : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "Face")
        {
            Debug.Log("tag");
            col.transform.Translate(Vector3.left * (Time.deltaTime * speed), Space.Self);
        }
    }
}
