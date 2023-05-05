using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float spawnRate = 3f;    

    [SerializeField] private GameObject[] enemyPrefabs;
    [SerializeField] private Transform[] spawnPoints;

    [SerializeField] private bool canSpawn = true;

    //ajuntar o sistema de pontuação pra customizar a dificuldade do jogo 

    private void Start() => StartCoroutine(Spawner());

    private IEnumerator Spawner()
    {
        //recebe um valor para o intervalo de espera(spawnRate)
        WaitForSeconds wait = new WaitForSeconds(spawnRate);

        while (canSpawn) 
        { 
            yield return wait;
            //recebe os prefabs dos inimigos e spawna eles aleatoriamente
            int enemyRandom = Random.Range(0, enemyPrefabs.Length);
            GameObject enemyToSpawn = enemyPrefabs[enemyRandom];

            int spawnPointsRandom = Random.Range(0, spawnPoints.Length);
            Transform spawnPointsPosition
                = spawnPoints[spawnPointsRandom];

            Instantiate(enemyToSpawn, spawnPointsPosition.position, Quaternion.identity);
        }
    }


}
