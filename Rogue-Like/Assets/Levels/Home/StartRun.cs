using UnityEngine;
using UnityEngine.SceneManagement;

public class StartRun : MonoBehaviour
{
    public LevelStats levelStats;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Start Run");

            levelStats.BeginRunStats(); //NEED TO MOVE IT TO GAMEOBJECT TO BE CALLED ONLY ONCE
            SceneManager.LoadScene(1);
        }
    }
}
