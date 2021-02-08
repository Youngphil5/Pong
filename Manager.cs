using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public RightPlayer rightPlayer;
    public LeftPlayer leftPlayer;
    public float moveSpeed = 2f;


    void Update()
    {
        if (Input.GetButton("RightPaddle"))
        {
            rightPlayer.gameObject.transform.localPosition += 
                Input.GetAxis("RightPaddle") * transform.forward * Time.deltaTime * moveSpeed;
        }
        if (Input.GetButton("LeftPaddle"))
        {
            leftPlayer.gameObject.transform.localPosition += 
                Input.GetAxis("LeftPaddle") * transform.forward * Time.deltaTime * moveSpeed;
        }
        
        
    }
}
