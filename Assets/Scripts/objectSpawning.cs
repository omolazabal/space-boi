using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawning : MonoBehaviour {

    public GameObject player;
    public GameObject[] coins;
    public GameObject[] asteroids;
    public GameObject[] asteroidsRHS;
    public GameObject enemy;

	private float coinSpawnTimer = 1.0f;
    private float enemySpawnTimer = 3.0f;
    private float asteroidSpawnTimer = 0.5f;
    private float asteroidRHSSpawnTimer = 0.5f;

    // Update is called once per frame
    void Update () {

        coinSpawnTimer -= Time.deltaTime;
        enemySpawnTimer -= Time.deltaTime;
        asteroidSpawnTimer -= Time.deltaTime;
        asteroidRHSSpawnTimer -= Time.deltaTime;

        if (coinSpawnTimer < 0.01)
        {
            SpawnCoins();
        }
        if (enemySpawnTimer < 0.01)
        {
            SpawnEnemy();
        }
        if (asteroidSpawnTimer < 0.01)
        {
            SpawnAsteroids();
        }
        if (asteroidRHSSpawnTimer < 0.01)
        {
            SpawnAsteroidsRHS();
        }

    }

    void SpawnCoins ()
    {
        Instantiate(coins[(Random.Range(0, coins.Length))], new Vector3(player.transform.position.x + 70, Random.Range(4, 10), 0), Quaternion.identity);
        coinSpawnTimer = Random.Range(1.0f, 3.0f);
    }

    void SpawnEnemy()
    {
        enemy.transform.localScale = new Vector3(Random.Range(3, 5), Random.Range(3, 5), Random.Range(3, 5));
        Instantiate(enemy, new Vector3(player.transform.position.x + 70, Random.Range(1, 12), 0), Quaternion.identity);
        enemySpawnTimer = Random.Range(.5f, .6f);
    }

    void SpawnAsteroids()
    {
        Instantiate(asteroids[(Random.Range(0, asteroids.Length))], new Vector3(player.transform.position.x + 90, Random.Range(-10,22), Random.Range(5, 30)), Quaternion.identity);
        asteroidSpawnTimer = 0.2f;
    }

    void SpawnAsteroidsRHS()
    {
        Instantiate(asteroidsRHS[(Random.Range(0, asteroidsRHS.Length))], new Vector3(player.transform.position.x + 90, Random.Range(-10, 22), Random.Range(-5, -30)), Quaternion.identity);
        asteroidRHSSpawnTimer = 0.2f;
    }
}
