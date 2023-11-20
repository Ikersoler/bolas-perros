using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballsSpawun : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPrefabArray;

    private int ballIndex;
    private float spawnRangex = 25f;
    private float spawnPosy = 25f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spaunInterval = 1.5f;



    private void Start()
    {


        InvokeRepeating("SpawnRandomBall",
            startDelay, spaunInterval);



    }

    private void SpawnRandomBall()
    {
        ballIndex = Random.Range(0, ballPrefabArray.Length);
        Instantiate(ballPrefabArray[ballIndex],
         RandomSpawnPos(),
         Quaternion.Euler(x: 0, y: 0, z: 0));
    }

    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangex, spawnRangex);
        return new Vector3(randomX, y: 0, spawnPosy);
    }
}
