using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTimeSpawner : MonoBehaviour
{

    //Spawn this object
    public GameObject[] spawnObjects;

    public float maxTime = 5;
    public float minTime = 2;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;
        int index = Random.Range(0, spawnObjects.Length);
        Debug.Log(index);
        GameObject objectToSpawn = spawnObjects[index];
         Instantiate(objectToSpawn, transform.position, objectToSpawn.transform.rotation);
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

}
