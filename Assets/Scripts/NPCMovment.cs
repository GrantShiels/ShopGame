using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovment : MonoBehaviour
{


    //NPC RigidBody
    Rigidbody2D NPCBody;


    //Following Vars used to control when the NPC will move
    public bool isWalking;
    public float walkTime;
    private float walkCounter;
    public float waitTime;
    private float waitCounter;


    //Float values for both the verticall and horizontal directions
    float horizontal;
    float vertical;

    //move speed
    public float moveSpeed = 10.0f;

    //will be used to determine which direction the NPC will move
    private int walkDirection;

    // Start is called before the first frame update
    void Start()
    {
        //Find the NPC rigid body
        NPCBody = GetComponent<Rigidbody2D>();

        //set up counters and time
        walkCounter = walkTime;
        waitCounter = waitTime;

        ChooseDirection();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the NPC is walking
        if (isWalking)
        {
            walkCounter -= Time.deltaTime;

            //Set direction depedning on each move direction number
            switch (walkDirection)
            {
                case 0:
                NPCBody.velocity = new Vector2(0, moveSpeed);
                break;

                case 1:
                NPCBody.velocity = new Vector2(moveSpeed, 0);
                break;

                case 2:
                NPCBody.velocity = new Vector2(0, -moveSpeed);
                break;

                case 3:
                NPCBody.velocity = new Vector2(-moveSpeed, 0);
                break;
            }


            //If the counter is 0 stop walking
            if (walkCounter < 0)
            {
                isWalking = false;
                waitCounter = waitTime;
            }
            
        }

        else
        {
            waitCounter -= Time.deltaTime;

            NPCBody.velocity = Vector2.zero;

            if (waitCounter < 0)
            {
                ChooseDirection();
            }
        }
    }


    //function that chooses which direction the NPC will move
    public void ChooseDirection()
    {

        //Choose random direction
        walkDirection = Random.Range (0,4);
        isWalking = true;
        walkCounter = walkTime;

    }





}