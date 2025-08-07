using UnityEngine;

[CreateAssetMenu(fileName = "EnemyStats", menuName = "ScriptableObjects/EnemyStatsScriptableObject", order = 3)]
public class EnemyStats : ScriptableObject
{
    public GameObject prefabSlime;

    public int hp;
    public int totalEnemiesInScene = 0;

    public void Slime01Stats()
    {
        hp = 20;
    }
}
