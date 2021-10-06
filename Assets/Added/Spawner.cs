using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public bool canSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 60f);
    }
    void SpawnEnemy()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
