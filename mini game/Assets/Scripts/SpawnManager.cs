using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public bool isGameActive = false;

    public float areaRange = 20f;
    public int coinAmount = 10 ;
    
    public GameObject collectibleObject;

    public GameObject enemyObject;


    // Start is called before the first frame update
    void Start()
    {   

            //StartCoroutine(CreateRandomAmountOfEnemies());  
        //SpawnRandomEnemy();
        //StartCoroutine(CreateRandomAmountOfEnemies());  
        SpawnCollectibleObject();
    }

    public void StartSpawner()
    {
        isGameActive = true;
        StartCoroutine(CreateRandomAmountOfEnemies());
    }

    public void StopSpawner()
    {
        isGameActive = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        Instantiate(enemyObject, CreateRandomSpawnPositon(), enemyObject.transform.rotation);
    }

    void SpawnCollectibleObject()

    {
        for (int i = 0; i < coinAmount; i++)


        {

            Instantiate(collectibleObject, CreateRandomSpawnPositon(), collectibleObject.transform.rotation);

        }
        coinAmount = 2;
    }

    Vector3 CreateRandomSpawnPositon()
    {
        float xValue = Random.Range(-areaRange, areaRange);
        float zValue = Random.Range(-areaRange, areaRange);
        Vector3 randomPosition = new Vector3(xValue, 1f , zValue);

        return randomPosition;
    }

    IEnumerator CreateRandomAmountOfEnemies()
    {
        while (isGameActive)

        {
            int amountOfTime = Random.Range(1, 8);
            yield return new WaitForSeconds(amountOfTime);

            int amountOfEnemies = Random.Range(1, 3);
            for(int i = 0; i < amountOfEnemies; i++)
            {
                 SpawnRandomEnemy();
            }
        }

    }
}
