using UnityEngine;
using UnityEngine.SceneManagement;

public class CHEATS : MonoBehaviour
{
    public PlayerStats playerStats;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Asterisk))
        {
            playerStats.currentTime = playerStats.time;
        }
    }
}
