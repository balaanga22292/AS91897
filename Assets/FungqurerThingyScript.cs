using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Rendering;

public class FungqurerThingyScript : MonoBehaviour
{
    public float moveSpeed = 5.0f;
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
            Debug.Log("Fungqurer Sprite Deleted.");
            Destroy(gameObject);
        }
    }
}
