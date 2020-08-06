using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{


    //NPC RigidBody
    Rigidbody2D NPCBody;

    //Float values for both the verticall and horizontal directions
    float horizontal;
    float vertical;

    //move speed
    public float moveSpeed = 10.0f;


    // Start is called before the first frame update
    void Start()
    {

        NPCBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
