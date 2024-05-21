using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;
    private float randomX;
    Vector2 whereToSpawn;
    public float spawnDelay;
    float nextSpawm = 0.0f;

    void Update()
    {
        if(Time.time > nextSpawm)
        {
            nextSpawm = Time.time + spawnDelay;
            randomX = Random.Range(-10, 10);
            whereToSpawn = new Vector2(randomX,2f);
            GameObject Enemy = Instantiate(obj, whereToSpawn, Quaternion.identity);
        }
    }
}