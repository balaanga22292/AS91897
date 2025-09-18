using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GhosteriaSpawnerScript : MonoBehaviour
{
    public GameObject ghosteria; // Reference to the Ghosteria prefab
    public float spawnRate = 2.0f; // Time in seconds between spawns
    private float timer = 0;
    public float heightOffset = 10.0f; // Vertical offset for spawning



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnGhosteria();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnGhosteria();
            timer = 0;
        }


    }

    void spawnGhosteria()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(ghosteria, new Vector3(transform.position.x, Random.Range (lowestPoint, highestPoint)), transform.rotation);
    }
}
