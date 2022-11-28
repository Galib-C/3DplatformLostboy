using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    //Create a public array of object to spawn, we will fill this up using the unity editor
    public GameObject[] objectToSpawn;

    float timeToNextSpawn;
    float timeSinceLastSpawn = 0.0f; //minimum amount of time between spawning objects

    public float minSpawnTime = 0.5f;
    public float maxSpawnTime = 3.0f;

    void Start()
    {
        //random.rage returns a random float between two values
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }


    void Update()
    {
        //add time.deltatime return the amount of time passed since the last time
        //this will create a float that counts up in seconds
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //if we have counted past the amount of time we need to wait ..

        if (timeSinceLastSpawn > timeToNextSpawn)

        {
            // use random.range to pick up a number between 0 and the amount of item we have on our object list
            int selection = Random.Range(0, objectToSpawn.Length);

            //instantiate spawns a gameobject - in this case we tell it to spawn a gameobject from our objectstospawn list
            //the second parameter in the brackets tell is where to spawn, so we've entered the position of the spawner.
            //the third parameter is for rotation, and quaternion.identity means no rotation
            Instantiate(objectToSpawn[selection], transform.position, Quaternion.identity);

            //after spawning, we select a new random time for the next spawn and set our timer back to zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;
        }


    }
}
