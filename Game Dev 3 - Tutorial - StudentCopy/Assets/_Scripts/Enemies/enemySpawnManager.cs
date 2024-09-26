using UnityEngine;

public class enemySpawnManager : MonoBehaviour
{
    //array to store points
    [SerializeField] Transform[] spawnPoints;
    //store delay between spawns
    [SerializeField] float delayBetweenSpawns;
    //integer array to store number of enemies spawned
    [SerializeField] int numberOfEnemiesSpawned;
    //store delay between waves
    [SerializeField] float delayBetweenWaves;
    //array to store all prefabs
    [SerializeField] GameObject enemyPrefab;
    //array to store all variation of enemies
    [SerializeField] EnemyData[] enemyData;
    //amount of waves
    [SerializeField] int waveNumber;
    //currernt wave we are on 
    private int currentWaveCount = 0;


    IEnumerator SpawnWave()
    {
        //for loop will run for as many times as we want enemies to spawn
        for (int i = 0; i < numberOfEnemiesSpawned; i++)
        {
            //gets a random number each loop, local so it can be overwritten elsewhere and is only used here
            int randomInteger = randomInteger.Range(0, spawnPoints.Length - 1);
            //instantiate enemy ship prefab using the random number to select a random spawn point from the array of spawn points 
            GameObject spawnedShip = Instantiate(enemyPrefab, spawnPoints[randomInteger]);
            //these change the life speed and sprite of the prefab i just instantiated
            spawnedShip.GetComponent<EnemyVisual>().enemyData = enemyData[currentWaveCount]);
            spawnedShip.GetComponent<EnemyMovement>().enemyData = enemyData[currentWaveCount]);
            spawnedShip.GetComponent<EnemyLife>().enemyData = enemyData[currentWaveCount]);
            //return the time left before the next iteration allowing another ship spawn
            yield return new WaitForSeconds(delayBetweenSpawns);
        }

        currentWaveCount++; // iterate currentWaveCount by +1
        if(currentWaveCount > enemyData.Length - 1)//are we out of bounds of the array?
        {
            currentWaveCount = 0; //if so reset wave count
        }

    yield return new WaitForSeconds(delayBetweenWaves); //wait the time designated for the next wave
    StartCoroutine(SpawnWave());

    public void SpawnerLogic()
    {
        StartCoroutine(SpawnWave());
    }
}
