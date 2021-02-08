using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

//using Random = System.Random;

public class BallScript : MonoBehaviour
{
    public float velocity = 10f;
    
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocity);
        /*if (transform.position.x > 16 ||transform.position.x < -16)
        {
            transform.position = startPosition;

        }*/
        
    }

    private void OnCollisionEnter(Collision other)
    {
        //gameObject.tag = other.gameObject.tag;
        if (other.gameObject.tag == "LeftPlayer")
        {
            velocity += 2;
        }
        if (other.gameObject.tag == "RightPlayer")
        {
            velocity += 2;
        }
        

        //transform.localRotation.Set(90,2,0,0);
        //other.gameObject.transform.localRotation.x;= transform.localRotation.Set(,,6);
        //transform.Rotate(Vector3.forward, angle);
        //velocity = -velocity;




    }
}
