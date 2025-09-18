using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MCScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float jumpForce = 2.0f;          //jump force of the player
    public LogicManagerScript logic;
    public bool gameIsOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }


    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) == true && gameIsOver)
        {
            myRigidBody.linearVelocity = Vector2.up * jumpForce;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        gameIsOver = false;
    }
}
