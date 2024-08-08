using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform enemyPos;

    private void Start()
    {
        InvokeRepeating("EnemySpawn", 0.5f, 2f);
        Destroy(gameObject, 5);
    }

    void EnemySpawn()
    {
        Instantiate(enemy, enemyPos.position, enemyPos.rotation);
    }
}
