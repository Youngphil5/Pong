using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    
    //public static BallScript ball;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
             other.gameObject.tag= gameObject.tag;
            //other.gameObject.tag = ""
            //other.gameObject.transform.rotation.y = 0;
        }
    }
}
