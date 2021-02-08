using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddelL : MonoBehaviour
{
    // Start is called before the first frame update
    public BallScript ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "bottomwall")
        {
            ball.transform.Rotate(Vector3.forward, 180);
        }
        if (other.gameObject.tag == "LeftPlayer")
        {
            ball.transform.Rotate(Vector3.forward, 225);
        }
        if (other.gameObject.tag == "TopWall")
        {
            ball.transform.Rotate(Vector3.forward, 270);
        }

        other.gameObject.tag= gameObject.tag;
    }
}
