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


    // Start is called before the first frame update
    void Start()
    {
        //Find the NPC rigid body
        NPCBody = GetComponent<Rigidbody2D>();

        //set up counters and time
        walkCounter = walkTime;
        waitCounter = waitTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
