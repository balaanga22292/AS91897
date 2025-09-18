using UnityEngine;

public class FungqurerScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float moveSpeed = 2.0f;          //move speed of the fungqurer

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