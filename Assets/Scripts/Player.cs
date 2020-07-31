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



    void Start()
    {
        //Get RigidBody and allocate it to playerBody
        playerBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");   
    }


    private void FixedUpdate() 
    {
        //set the body velocity
        playerBody.velocity = new Vector2(horizontal * moveSpeed, vertical * moveSpeed);
        
    }
}
