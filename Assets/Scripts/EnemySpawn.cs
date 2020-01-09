using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;

    private float randX;
    private Vector3 whereToSpawn;
    private float spawnRate = 1.5f;
    private float nextSpawn;


    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-3.5f, 3.5f);

            whereToSpawn = new Vector3(randX, 8, 0);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}