using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddelR : MonoBehaviour
{
    public BallScript ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "LeftPlayer")
        {
            ball.transform.Rotate(Vector3.forward, 135);
        }
        else if (other.gameObject.tag == "TopWall")
        {
            ball.transform.Rotate(Vector3.forward, 190);
        }
        else if (other.gameObject.tag == "bottomwall")
        {
            ball.transform.Rotate(Vector3.forward, 90);
        }
        other.gameObject.tag= gameObject.tag;
        
        
    }
}
