using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawn Settings Of Gainer")]
    public GameObject gainPrefab;
    [SerializeField] private float spawnPosX = 7.0f;
    [SerializeField] private float spawnPosZ = 24.0f;
    [SerializeField] private float spawnPosY = 1.49f;
    [SerializeField] private float startDelay = 10.0f;
    [SerializeField] private float spawnInterval = 10.0f;
    [Header("Spawn Settings Of Gainer")]
    [SerializeField] private float spawnPosEnemyDiceY = 3.0f;
    [SerializeField] private float startDelayEnemyDice = 5.0f;
    [SerializeField] private float spawnIntervalEnemyDice = 5.0f;
    public GameObject enemyDice;
    public GameObject wall;


    void Start()
    {
       
        InvokeRepeating("SpawnRandomGainer", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomEnemyDice", startDelayEnemyDice, spawnIntervalEnemyDice);
    }

    
    void Update()
    {
        
    }
    void SpawnRandomGainer()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), -spawnPosY, Random.Range(-spawnPosZ, spawnPosZ));
        Instantiate(gainPrefab, spawnPos, gainPrefab.transform.rotation);
    }
    void SpawnRandomEnemyDice()
    {
      
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), spawnPosEnemyDiceY, Random.Range(wall.transform.position.z+5.0f, spawnPosZ));
        Instantiate(enemyDice, spawnPos, enemyDice.transform.rotation);
    }
    

}
