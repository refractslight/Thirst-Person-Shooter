﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceMovement : MonoBehaviour
{


    public GameObject face;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      MoveFace();      
    }

    public void MoveFace(){
      if(face.transform.position.x > 0){
        
      }  
    }

}
