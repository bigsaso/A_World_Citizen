using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    public float timeBtwSpawns = 3f;
    private Vector2 screenBounds;
    public bool canSpawn = true;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(zombieWave());
    }

    private void spawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab) as GameObject;
        enemy.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator zombieWave()
    {
        while (canSpawn)
        {
            yield return new WaitForSeconds(timeBtwSpawns);
            spawnEnemy();
        }
    }
}
