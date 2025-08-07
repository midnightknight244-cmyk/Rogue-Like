using UnityEngine;

public class BeginLevel : MonoBehaviour
{
    public LevelStats levelStats;
    public EnemyStats enemyStats;
    public PlayerStats playerStats;
    public Collectibles collectibles;

    void Start()
    {
        Debug.Log("levelStats.level: " + levelStats.level);
        enemyStats.totalEnemiesInScene = 0;
        levelStats.WhatLevel();
        levelStats.endOfLevel = false;
        collectibles.ResetValues();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
