using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
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
        if (other.gameObject.tag == "RightPlayer")
        {
            other.gameObject.transform.Rotate(Vector3.forward, 245);
        }
        if (other.gameObject.tag == "LeftPlayer")
        {
            other.gameObject.transform.Rotate(Vector3.forward, 115);
        }

        other.gameObject.tag = tag;
    }
}
