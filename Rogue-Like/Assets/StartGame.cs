using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class StartGame : MonoBehaviour
{
    [SerializeField] private InputActionAsset input;

    private void Start()
    {
        input.Disable();
    }

    public void BeginGame()
    {
        SceneManager.LoadScene(1);
    }
}
