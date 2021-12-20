using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropSpawn : MonoBehaviour
{
    public GameObject dropPrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public Transform spawnPoint3;
    public Transform spawnPoint4;
    public Transform spawnPoint5;
    public Transform spawnPoint6;
    public Transform spawnPoint7;
    public Transform spawnPoint8;
    public Transform spawnPoint9;

    public float spawnRangeStart = 0.5f;
    public float spawnRangeEnd = 1.2f;
    private float timeToSpawn;
    private float spawnTimer = 0f;
    private Transform spawnPoint;

    void FixedUpdate()
    {
        timeToSpawn = Random.Range(spawnRangeStart, spawnRangeEnd);
        spawnTimer += 0.01f;
        if (spawnTimer >= timeToSpawn)
        {
            spawnTree();
            spawnTimer = 0f;
        }
    }

    void spawnTree()
    {
        //int SPnum = Random.Range(1, 2);
        //if (SPnum == 1) { spawnPoint = spawnPoint1; }
        //else if (SPnum == 2) { spawnPoint = spawnPoint2; }
        //else if (SPnum == 3) { spawnPoint = spawnPoint3; }
        //else if (SPnum == 4) { spawnPoint = spawnPoint4; }
        //else if (SPnum == 5) { spawnPoint = spawnPoint5; }

        Instantiate(dropPrefab, spawnPoint1.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint2.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint3.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint4.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint5.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint6.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint7.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint8.position, Quaternion.identity);
        Instantiate(dropPrefab, spawnPoint9.position, Quaternion.identity);
    }
}
