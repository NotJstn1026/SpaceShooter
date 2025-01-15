using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyPrefab;
    [SerializeField]
    private float spawnIntervall = 3f;


    private void Start()
    {
        StartCoroutine(SpawnObstacles());   
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
    }


    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(spawnIntervall);
        }

    }
}
