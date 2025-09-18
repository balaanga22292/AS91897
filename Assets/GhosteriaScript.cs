using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GhosteriaScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float moveSpeed = 2.0f;          //move speed of the ghost
    public float deadZone = -5;         //after sprite passes point (x-value) -5 it is destroyed


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Debug.Log("Ghosteria Sprite Deleted.");
            Destroy(gameObject);
        }
    }
}
