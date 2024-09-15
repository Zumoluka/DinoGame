using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform spawnPoint;
    public float spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnInterval, spawnInterval);
    }

    void SpawnObstacle()
    {
        GameObject obstacle = ObjectPool.Instance.GetObjectFromPool();
        obstacle.transform.position = spawnPoint.position;
        obstacle.SetActive(true);
    }
}
