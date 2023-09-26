using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaManager : MonoBehaviour
{
    public GameObject monedaPrefab;
    public int poolSize = 10;
    public float spawnRate = 3.0f;
    public float minYSpawn = -5.0f;
    public float maxYSpawn = 5.0f;

    private List<GameObject> objectPool;

    private void Start()
    {
        objectPool = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {
            GameObject coin = Instantiate(monedaPrefab);
            coin.SetActive(false);
            objectPool.Add(coin);
        }
        InvokeRepeating("RespawnCoin", 0f, spawnRate);
    }

    private void Update()
    {
    }


    private void RespawnCoin()
    {
        foreach (var coin in objectPool)
        {
            if (!coin.activeInHierarchy)
            {
                // Coloca al enemigo en una posición inicial
                coin.transform.position = new Vector3(transform.position.x, Random.Range(minYSpawn, maxYSpawn), 0f);
                coin.SetActive(true);
                break; // Solo activa un enemigo a la vez
            }
        }
    }
}
