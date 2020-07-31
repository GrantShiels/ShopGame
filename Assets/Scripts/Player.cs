using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Player RigidBody
    Rigidbody2D playerBody;

    //Float values for both the verticall and horizontal directions
    float horizontal;
    float vertical;

    //move speed
    public float moveSpeed = 10.0f;

    //max move speed, used for diagonal movment
    float moveLimiter = 0.7f;



    void Start()
    {
        //Get RigidBody and allocate it to playerBody
        playerBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //gets the input keys and moves the player that direction
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");   
    }


    private void FixedUpdate() 
    {
        //checks to see if the player is moving diagonally
        if (horizontal != 0 && vertical != 0)
        {
            //add the move limiter 
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
        }



        //set the body velocity
        playerBody.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        
    }
}
