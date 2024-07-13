using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject spawnObject;
    
    public float spawnRate = 1;
    float spawnTimeLeft;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnTimeLeft = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimeLeft = spawnTimeLeft - Time.deltaTime;
        if (spawnTimeLeft <= 0) 
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x = spawnPosition.x + Random.Range(-10, 10);
            spawnPosition.z = spawnPosition.z + Random.Range(-10, 10);
            Instantiate(spawnObject, spawnPosition, Quaternion.identity);
            spawnTimeLeft = spawnRate;
        }
        
    }
}
