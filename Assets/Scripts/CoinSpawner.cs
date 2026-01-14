using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private float minSpawnTime = 1.5f;
    [SerializeField] private float maxSpawnTime = 3.5f;
    [SerializeField] private float spawnX = 10f;
    [SerializeField] private float spawnY = 14f;

    private void Start()
    {
        StartCoroutine(SpawnCoins());
    }

    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnTime, maxSpawnTime));

            Vector2 spawnPos = new Vector2(spawnX, spawnY);
            Instantiate(coinPrefab, spawnPos, Quaternion.identity);
        }
    }
}
