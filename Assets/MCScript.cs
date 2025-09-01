using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MCScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float jumpForce = 2.0f;          //jump force of the player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            myRigidBody.linearVelocity = Vector2.up * jumpForce;
        }
    }
}
