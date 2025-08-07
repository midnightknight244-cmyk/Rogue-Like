using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu(fileName = "LevelStats", menuName = "ScriptableObjects/LevelStatsScriptableObject", order = 2)]
public class LevelStats : ScriptableObject
{
    public EnemyStats enemyStats;
    public Collectibles collectibles;

    public int level;
    public int numberOftotalEnemies = 0;
    public int waves;
    public int numberOfSpawnPoints;
    public int coin;

    public bool endOfLevel = false;

    private GameObject enemy;
    private GameObject[] spawnPoints;

    public void BeginRunStats()
    {
        level = 2;
        waves = 0;
        numberOftotalEnemies = 0;
        endOfLevel = false;
        coin = 0;
    }

    public void WhatLevel()
    {
        Debug.Log("Start of WhatLevel()");
        if (level == 2)
        {
            Debug.Log("level == 2");
            Level01Stats();
        }
        else if (level == 3)
        {
            Level02Stats();
        }
    }

    private void Level01Stats()
    {
        waves = 1;
        numberOftotalEnemies = 3;

        CreateMonsters();
    }

    private void Level02Stats()
    {
        waves = 2;
        numberOftotalEnemies = 8;

        CreateMonsters();
    }

    private void FindNumberOfSpawnPoints()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("Spawn");

        numberOfSpawnPoints = spawnPoints.Length;
    }

    public void CreateMonsters()
    {
        FindNumberOfSpawnPoints();

        Debug.Log("numberOfSpawnPoints: " + numberOfSpawnPoints + " numberOfTotalEnemies: " + numberOftotalEnemies + " waves: " + waves);
        for (int i = 0; i < numberOfSpawnPoints; i++)
        {
            enemyStats.Slime01Stats();

            if (level == 2)
            {
                Debug.Log("From Create Monsters: level = 2");
                enemy = Instantiate(enemyStats.prefabSlime);
            }
            else if (level == 3)
            {
                Debug.Log("From CreateMonsters(): level = 3");
                enemy = Instantiate(enemyStats.prefabSlime);
            }

            enemy.transform.position = spawnPoints[i].transform.position;

            numberOftotalEnemies--;
            enemyStats.totalEnemiesInScene++;
        }

        Debug.Log(enemyStats.totalEnemiesInScene);
    }

    public void CheckIfMonstersDefeated()
    {
        //Debug.Log(enemyStats.totalEnemiesInScene);
        if (enemyStats.totalEnemiesInScene == 0)
        {
            //Debug.Log("end of wave");

            waves--;
            //Debug.Log("wave: " + waves);

            CheckIfWavesDone();
        }
    }

    private void CheckIfWavesDone()
    {
        if (waves <= 0)
        {
            waves = 0;
            Debug.Log("end of level");

            endOfLevel = true;

            GameObject door = GameObject.Find("Door");

            door.gameObject.SetActive(true);

            if (collectibles.isRewardGenerated == false)
            {
                int random = Random.Range(0, collectibles.totalCollectiblesTypes);

                if (random == 0)
                {
                    collectibles.GenerateCoin();
                }
                else if (random == 1)
                {
                    collectibles.GenerateHourglass();
                }
            }
        }

        else
        {
            CreateMonsters();
        }
    }
}
