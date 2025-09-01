using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GhosteriaScript : MonoBehaviour
{

    public float moveSpeed = 2.0f;          //move speed of the ghost


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
    }
}
