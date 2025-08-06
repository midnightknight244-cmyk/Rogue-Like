using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "ScriptableObjects/PlayerStatsScriptableObject", order = 1)]
public class PlayerStats : ScriptableObject
{
    public bool canMove;

    public float time;
    public float currentTime;
    
    //SHOULD BE CALLED AT THE START OF THE GAME 
    public void StartingStats()
    {
        time = 30.0f;
    }
}
