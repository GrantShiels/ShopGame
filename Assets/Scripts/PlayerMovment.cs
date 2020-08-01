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

    //Animator for the PC animaton
    public Animator playerAnimator;

    //movment gets both the x and y to determine which move direction
    Vector2 movment;

    //Renderer for PC
    public SpriteRenderer playerRenderer;

    // Update is called once per frame
    //Will handle input
    void Update()
    {
        //get input from keys and add them to the Vector2
        movment.x = Input.GetAxisRaw("Horizontal");
        movment.y = Input.GetAxisRaw("Vertical");

        playerAnimator.SetFloat("Speed", movment.sqrMagnitude);


        //Used to change the direction the PC is facing
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            playerRenderer.flipX = true;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            playerRenderer.flipX = false;
        }

        
    }

    //fixed update time, not connected to frames. 
    //Will handle movment
    void FixedUpdate() 
    {

        playerRB.MovePosition(playerRB.position + movment * moveSpeed * Time.fixedDeltaTime);
        
    }

}
