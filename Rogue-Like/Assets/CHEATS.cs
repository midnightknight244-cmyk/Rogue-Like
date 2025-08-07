using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CHEATS : MonoBehaviour
{
    public PlayerStats playerStats;

    private void FixedUpdate()
    {
        if (Keyboard.current.numpad1Key.isPressed)
        {
            SceneManager.LoadScene(0);
        }

        if (Keyboard.current.numpad0Key.isPressed)
        {
            playerStats.currentTime = playerStats.time;
        }
    }
}
