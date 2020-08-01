using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that will be used to control how the PC moves
public class PlayerMovment : MonoBehaviour
{
    
    //The speed that the PC can move
    public float moveSpeed = 5f;

    //the rigid body for the PC
    public Rigidbody2D playerRB;

    //movment gets both the x and y to determine which move direction
    Vector2 movment;

    // Update is called once per frame
    //Will handle input
    void Update()
    {
        //get input from keys and add them to the Vector2
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");
    }

    //fixed update time, not connected to frames. 
    //Will handle movment
    void FixedUpdate() 
    {

        playerRB.MovePosition(playerRB.position + movment * moveSpeed * Time.fixedDeltaTime);
        
    }
}
