using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{ public GameObject[] obstaculo;
   public float SpawnRate = 3.0f;
    private float timer = 0f;
    public Transform SpawnPoint;



   
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= SpawnRate) { SpawnObstaculo();
            timer = 0f;
        }
    }
    void SpawnObstaculo()
    {
        int Rand = Random.Range(0, obstaculo.Length);
        Instantiate(obstaculo[Rand],SpawnPoint.position,SpawnPoint.rotation);
    }
}
