using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FunqurerSpawnerScriptActual : MonoBehaviour
{
    public GameObject fungqurer; // Reference to the fungqurer prefab
    public float spawnRate = 2.0f; // Time in seconds between spawns
    private float timer = 0;
    public float heightOffset = 10.0f; // Vertical offset for spawning

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnFungqurer();
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
            spawnFungqurer();
            timer = 0;
        }


    }

    void spawnFungqurer()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(fungqurer, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}